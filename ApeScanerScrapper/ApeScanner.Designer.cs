namespace ApeScanerScrapper
{
    partial class ApeScanner
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApeScanner));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShitCoinsGrid = new System.Windows.Forms.DataGridView();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkPoocoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liquidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numHoldersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkReadContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holderAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holderPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerRenouncedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shitCointContractTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shitcoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitCoinsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shitcoinBindingSource)).BeginInit();
            this.tblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvShitCoinsGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblButtons, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.80037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19963F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1295, 541);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvShitCoinsGrid
            // 
            this.dgvShitCoinsGrid.AllowUserToAddRows = false;
            this.dgvShitCoinsGrid.AllowUserToDeleteRows = false;
            this.dgvShitCoinsGrid.AutoGenerateColumns = false;
            this.dgvShitCoinsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShitCoinsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.linkBalanceDataGridViewTextBoxColumn,
            this.linkContractDataGridViewTextBoxColumn,
            this.linkPoocoinDataGridViewTextBoxColumn,
            this.marketCapDataGridViewTextBoxColumn,
            this.Liquidity,
            this.numHoldersDataGridViewTextBoxColumn,
            this.linkReadContractDataGridViewTextBoxColumn,
            this.lpLinkDataGridViewTextBoxColumn,
            this.holderAdressDataGridViewTextBoxColumn,
            this.holderPercentDataGridViewTextBoxColumn,
            this.ownerRenouncedDataGridViewCheckBoxColumn,
            this.shitCointContractTypeDataGridViewTextBoxColumn});
            this.dgvShitCoinsGrid.DataSource = this.shitcoinBindingSource;
            this.dgvShitCoinsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShitCoinsGrid.Location = new System.Drawing.Point(3, 3);
            this.dgvShitCoinsGrid.Name = "dgvShitCoinsGrid";
            this.dgvShitCoinsGrid.ReadOnly = true;
            this.dgvShitCoinsGrid.Size = new System.Drawing.Size(1289, 468);
            this.dgvShitCoinsGrid.TabIndex = 1;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkBalanceDataGridViewTextBoxColumn
            // 
            this.linkBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkBalanceDataGridViewTextBoxColumn.DataPropertyName = "LinkBalance";
            this.linkBalanceDataGridViewTextBoxColumn.HeaderText = "LinkBalance";
            this.linkBalanceDataGridViewTextBoxColumn.Name = "linkBalanceDataGridViewTextBoxColumn";
            this.linkBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkBalanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // linkContractDataGridViewTextBoxColumn
            // 
            this.linkContractDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkContractDataGridViewTextBoxColumn.DataPropertyName = "LinkContract";
            this.linkContractDataGridViewTextBoxColumn.HeaderText = "LinkContract";
            this.linkContractDataGridViewTextBoxColumn.Name = "linkContractDataGridViewTextBoxColumn";
            this.linkContractDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkContractDataGridViewTextBoxColumn.Visible = false;
            // 
            // linkPoocoinDataGridViewTextBoxColumn
            // 
            this.linkPoocoinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkPoocoinDataGridViewTextBoxColumn.DataPropertyName = "LinkPoocoin";
            this.linkPoocoinDataGridViewTextBoxColumn.HeaderText = "LinkPoocoin";
            this.linkPoocoinDataGridViewTextBoxColumn.Name = "linkPoocoinDataGridViewTextBoxColumn";
            this.linkPoocoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkPoocoinDataGridViewTextBoxColumn.Visible = false;
            // 
            // marketCapDataGridViewTextBoxColumn
            // 
            this.marketCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marketCapDataGridViewTextBoxColumn.DataPropertyName = "MarketCap";
            this.marketCapDataGridViewTextBoxColumn.HeaderText = "Market cap ($)";
            this.marketCapDataGridViewTextBoxColumn.Name = "marketCapDataGridViewTextBoxColumn";
            this.marketCapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Liquidity
            // 
            this.Liquidity.DataPropertyName = "Liquidity";
            this.Liquidity.HeaderText = "Liquidity";
            this.Liquidity.Name = "Liquidity";
            this.Liquidity.ReadOnly = true;
            // 
            // numHoldersDataGridViewTextBoxColumn
            // 
            this.numHoldersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numHoldersDataGridViewTextBoxColumn.DataPropertyName = "NumHolders";
            this.numHoldersDataGridViewTextBoxColumn.HeaderText = "Number of holders";
            this.numHoldersDataGridViewTextBoxColumn.Name = "numHoldersDataGridViewTextBoxColumn";
            this.numHoldersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkReadContractDataGridViewTextBoxColumn
            // 
            this.linkReadContractDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkReadContractDataGridViewTextBoxColumn.DataPropertyName = "LinkReadContract";
            this.linkReadContractDataGridViewTextBoxColumn.HeaderText = "LinkReadContract";
            this.linkReadContractDataGridViewTextBoxColumn.Name = "linkReadContractDataGridViewTextBoxColumn";
            this.linkReadContractDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkReadContractDataGridViewTextBoxColumn.Visible = false;
            // 
            // lpLinkDataGridViewTextBoxColumn
            // 
            this.lpLinkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lpLinkDataGridViewTextBoxColumn.DataPropertyName = "LpLink";
            this.lpLinkDataGridViewTextBoxColumn.HeaderText = "LpLink";
            this.lpLinkDataGridViewTextBoxColumn.Name = "lpLinkDataGridViewTextBoxColumn";
            this.lpLinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.lpLinkDataGridViewTextBoxColumn.Visible = false;
            // 
            // holderAdressDataGridViewTextBoxColumn
            // 
            this.holderAdressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holderAdressDataGridViewTextBoxColumn.DataPropertyName = "HolderAdress";
            this.holderAdressDataGridViewTextBoxColumn.HeaderText = "Contract holder adress";
            this.holderAdressDataGridViewTextBoxColumn.Name = "holderAdressDataGridViewTextBoxColumn";
            this.holderAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holderPercentDataGridViewTextBoxColumn
            // 
            this.holderPercentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holderPercentDataGridViewTextBoxColumn.DataPropertyName = "HolderPercent";
            this.holderPercentDataGridViewTextBoxColumn.HeaderText = "Contract holder %";
            this.holderPercentDataGridViewTextBoxColumn.Name = "holderPercentDataGridViewTextBoxColumn";
            this.holderPercentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerRenouncedDataGridViewCheckBoxColumn
            // 
            this.ownerRenouncedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ownerRenouncedDataGridViewCheckBoxColumn.DataPropertyName = "OwnerRenounced";
            this.ownerRenouncedDataGridViewCheckBoxColumn.HeaderText = "Owner renounced";
            this.ownerRenouncedDataGridViewCheckBoxColumn.Name = "ownerRenouncedDataGridViewCheckBoxColumn";
            this.ownerRenouncedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // shitCointContractTypeDataGridViewTextBoxColumn
            // 
            this.shitCointContractTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shitCointContractTypeDataGridViewTextBoxColumn.DataPropertyName = "ShitCointContractType";
            this.shitCointContractTypeDataGridViewTextBoxColumn.HeaderText = "Contract status";
            this.shitCointContractTypeDataGridViewTextBoxColumn.Name = "shitCointContractTypeDataGridViewTextBoxColumn";
            this.shitCointContractTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shitcoinBindingSource
            // 
            this.shitcoinBindingSource.DataSource = typeof(ApeScanerScrapper.Shitcoin);
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 5;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.Controls.Add(this.btnStart, 4, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 477);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(1289, 61);
            this.tblButtons.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(1031, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(255, 55);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStart.TabIndex = 3;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ApeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApeScanner";
            this.Text = "Ape Scaner";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitCoinsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shitcoinBindingSource)).EndInit();
            this.tblButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource shitcoinBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvShitCoinsGrid;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkPoocoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liquidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn numHoldersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkReadContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holderAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holderPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ownerRenouncedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shitCointContractTypeDataGridViewTextBoxColumn;
    }
}

