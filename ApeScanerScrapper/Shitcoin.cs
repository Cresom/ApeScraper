namespace ApeScanerScrapper
{
    public class Shitcoin
    {
        public enum ContractType
        {
            Good,
            Bad,
            Unknown
        }

        private string _key;

        public string Key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private string _linkBalance;
        public string LinkBalance
        {
            get => _linkBalance;
            set
            {
                _linkBalance = value;
            }
        }

        private string _linkContract;
        public string LinkContract
        {
            get => _linkContract;
            set
            {
                _linkContract = value;
            }
        }

        private string _linkPoocoin;
        public string LinkPoocoin
        {
            get => _linkPoocoin;
            set
            {
                _linkPoocoin = value;
            }
        }

        private decimal _marketCap;
        public decimal MarketCap
        {
            get => _marketCap;
            set
            {
                _marketCap = value;
            }
        }

        private decimal _liquidity;
        public decimal Liquidity
        {
            get => _liquidity;
            set
            {
                _liquidity = value;
            }
        }

        private int _numHolder;
        public int NumHolders
        {
            get => _numHolder;
            set
            {
                _numHolder = value;
            }
        }

        private string _linkReadContract;
        public string LinkReadContract
        {
            get => _linkReadContract;
            set
            {
                _linkReadContract = value;
            }
        }

        private string _lpLink;
        public string LpLink
        {
            get => _lpLink;
            set
            {
                _lpLink = value;
            }
        }

        private string _holderAdress;
        public string HolderAdress
        {
            get => _holderAdress;
            set
            {
                _holderAdress = value;
            }
        }

        private decimal _holderPercent;
        public decimal HolderPercent
        {
            get => _holderPercent;
            set
            {
                _holderPercent = value;
            }
        }

        private bool _ownerRenounced;
        public bool OwnerRenounced
        {
            get => _ownerRenounced;
            set
            {
                _ownerRenounced = value;
            }
        }

        private ContractType _shitCointContractType;
        public ContractType ShitCointContractType
        {
            get => _shitCointContractType;
            set
            {
                _shitCointContractType = value;
            }
        }

    }
}
