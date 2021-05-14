using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApeScanerScrapper.Shitcoin;

namespace ApeScanerScrapper
{
    public partial class ApeScanner : Form
    {
        private string url = "https://poocoin.app/ape";
        private IWebDriver driver;
        private List<Shitcoin> shitcoinList;
        private List<Shitcoin> shitcoinListAux;

        public ApeScanner()
        {
            InitializeComponent();
            shitcoinList = new List<Shitcoin>();
            dgvShitCoinsGrid.DataSource = shitcoinList;
        }

        public void StartBrowser()
        {
            shitcoinListAux = new List<Shitcoin>();
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(1000);

            //Find comboBox in web page and change versión.
            IWebElement comboButton = driver.FindElement(By.ClassName("form-select"));
            var selectElement = new SelectElement(comboButton);
            selectElement.SelectByValue("2");

            //Wait for the web page to load tokens.
            Thread.Sleep(10000);

            List<IWebElement> elementsCollection = driver.FindElements(By.TagName("tr")).ToList();

            foreach (IWebElement element in elementsCollection.Skip(1))
            {
                try
                {
                    List<IWebElement> info = element.FindElements(By.TagName("td")).ToList();
                    string key = info[0].FindElement(By.TagName("a")).GetAttribute("href").Substring(27);

                    if (!shitcoinList.Any(x => x.Key == key))
                    {
                        Shitcoin shitcoin = new Shitcoin();

                        shitcoin.Key = key;
                        shitcoin.Name = Regex.Replace(info[0].FindElement(By.TagName("a")).Text, "\\\r\\\n", " - ");

                        shitcoin.LinkBalance = "https://bscscan.com/token/" + shitcoin.Key + "#balances";
                        shitcoin.LinkReadContract = "https://bscscan.com/readContract?m=normal&a=" + shitcoin.Key + "&v=#readCollapse1";
                        shitcoin.LinkContract = "https://bscscan.com/address/" + shitcoin.Key + "#code";
                        shitcoin.LinkPoocoin = "https://poocoin.app/tokens/" + shitcoin.Key;

                        shitcoin.LpLink = info[2].FindElements(By.TagName("a")).FirstOrDefault(x => x.Text == "BNB LP Holders").GetAttribute("href");

                        shitcoinListAux.Add(shitcoin);
                    }
                }
                catch (Exception)
                {

                }           
            }

            foreach (Shitcoin shitcoin in shitcoinListAux)
            {
                try
                {
                    shitcoin.OwnerRenounced = GetOwnerRenounced(shitcoin.LinkReadContract);

                    GetHolderAdressAndPercent(shitcoin.LpLink, out string holderAdress, out decimal holderPercent);

                    shitcoin.HolderAdress = holderAdress;
                    shitcoin.HolderPercent = holderPercent;

                    shitcoin.ShitCointContractType = GetContractType(shitcoin.LinkContract);
                    shitcoin.NumHolders = GetNumHolders(shitcoin.LinkBalance);

                    GetMarketCapAndLiquidity(shitcoin.LinkPoocoin, out decimal marketCap, out decimal liquidity);

                    shitcoin.MarketCap = marketCap;
                    shitcoin.Liquidity = liquidity;

                    shitcoinList = shitcoinListAux;
                    
                    Invoke(new Action(() =>
                    {
                        dgvShitCoinsGrid.DataSource = shitcoinList;
                        dgvShitCoinsGrid.Refresh();
                    }));
                }
                catch (Exception)
                {
                    //ERROR
                }
            }
        }

        private bool GetOwnerRenounced(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);

            IWebElement element = driver.FindElements(By.TagName("a")).FirstOrDefault(x => x.Text.Contains(". owner"));
            if (element != null)
            {
                string positionNumber = Regex.Match(element.Text, @"\d+").Value;
                IWebElement elementAdress = driver.FindElement(By.Id("readCollapse" + positionNumber)).FindElement(By.TagName("a"));
                return elementAdress.Text.Contains("0x0000000000000000000000000000000000000000");
            }
            else
                return false;
        }

        private int GetNumHolders(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);
            driver.SwitchTo().Frame(driver.FindElement(By.Id("tokeholdersiframe")));

            IWebElement element = driver.FindElements(By.ClassName("hidden-xs")).FirstOrDefault(x => x.Text.Contains("From a total of") || x.Text.Contains("A total of"));

            if (element != null)
                return Convert.ToInt32(Regex.Match(element.Text, @"\d+").Value);
            else
            {
                element = driver.FindElements(By.TagName("p")).FirstOrDefault(x => x.Text.Contains("A total of"));
                if (element != null)
                    return Convert.ToInt32(Regex.Match(element.Text, @"\d+").Value);
            }
            return 0;
        }

        private void GetMarketCapAndLiquidity(string url, out decimal marketCap, out decimal liquidity)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(800);

            IWebElement elementMC = driver.FindElements(By.ClassName("px-3")).FirstOrDefault(x => x.Text.Contains("$"));
            string marketCapText = elementMC.FindElement(By.ClassName("text-success")).Text;

            if (elementMC != null)
                marketCap =  Convert.ToDecimal(marketCapText.Replace("$", "").Replace(",", ""));
            else
                marketCap = -1;

            IWebElement elementL = driver.FindElements(By.ClassName("px-3")).FirstOrDefault(x => x.Text.Contains("$"));
            string liquidityCapText = elementL.Text.Split('\n').FirstOrDefault(x => x.StartsWith("V2")).Split('(', ')')[1];

            if (elementL != null)
                liquidity = Convert.ToDecimal(liquidityCapText.Replace("$", "").Replace(",", ""));
            else
                liquidity = -1;
        }

        private void GetHolderAdressAndPercent(string url, out string adress, out decimal percent)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);

            driver.SwitchTo().Frame(driver.FindElement(By.Id("tokeholdersiframe")));
            IWebElement element = driver.FindElements(By.TagName("tr")).Where(x => x.FindElements(By.TagName("td")).Any(y => y.Text == "1")).FirstOrDefault();
            if (element != null)
            {
                adress = element.Text.Split(' ')[1];
                percent = Convert.ToDecimal(element.Text.Split(' ')[3].Replace("%", "").Replace(".", ","));
            }
            else
            {
                adress = "UNKNOWN";
                percent = -1;
            }
        }

        private ContractType GetContractType(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);

            IWebElement element = driver.FindElements(By.TagName("span")).FirstOrDefault(x => x.Text.Contains("(Exact Match)"));

            if (element != null)
                return ContractType.Good;

            element = driver.FindElements(By.TagName("span")).FirstOrDefault(x => x.Text.Contains("(Similar Match)"));

            if (element != null)
                return ContractType.Bad;
            else
                return ContractType.Unknown;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var task1 = new Task(() => StartBrowser(), TaskCreationOptions.AttachedToParent);
            task1.Start();
        }
    }
}
