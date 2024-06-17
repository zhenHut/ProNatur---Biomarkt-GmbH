namespace ProNatur___Biomarkt_GmbH
{
    partial class ProductsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsScreen));
            this.LblName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductBrand = new System.Windows.Forms.TextBox();
            this.LblMarke = new System.Windows.Forms.Label();
            this.LblKategorie = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.LblPreis = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.BtnProgramClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(13, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(81, 11);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(247, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            this.textBoxProductBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductBrand.ForeColor = System.Drawing.Color.White;
            this.textBoxProductBrand.Location = new System.Drawing.Point(81, 36);
            this.textBoxProductBrand.Name = "textBoxProductBrand";
            this.textBoxProductBrand.Size = new System.Drawing.Size(159, 20);
            this.textBoxProductBrand.TabIndex = 3;
            // 
            // LblMarke
            // 
            this.LblMarke.AutoSize = true;
            this.LblMarke.BackColor = System.Drawing.Color.Transparent;
            this.LblMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarke.ForeColor = System.Drawing.Color.White;
            this.LblMarke.Location = new System.Drawing.Point(13, 44);
            this.LblMarke.Name = "LblMarke";
            this.LblMarke.Size = new System.Drawing.Size(42, 13);
            this.LblMarke.TabIndex = 2;
            this.LblMarke.Text = "Marke";
            // 
            // LblKategorie
            // 
            this.LblKategorie.AutoSize = true;
            this.LblKategorie.BackColor = System.Drawing.Color.Transparent;
            this.LblKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKategorie.ForeColor = System.Drawing.Color.White;
            this.LblKategorie.Location = new System.Drawing.Point(13, 71);
            this.LblKategorie.Name = "LblKategorie";
            this.LblKategorie.Size = new System.Drawing.Size(61, 13);
            this.LblKategorie.TabIndex = 4;
            this.LblKategorie.Text = "Kategorie";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxProductPrice.Location = new System.Drawing.Point(81, 91);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(70, 20);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // LblPreis
            // 
            this.LblPreis.AutoSize = true;
            this.LblPreis.BackColor = System.Drawing.Color.Transparent;
            this.LblPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreis.ForeColor = System.Drawing.Color.White;
            this.LblPreis.Location = new System.Drawing.Point(13, 98);
            this.LblPreis.Name = "LblPreis";
            this.LblPreis.Size = new System.Drawing.Size(35, 13);
            this.LblPreis.TabIndex = 6;
            this.LblPreis.Text = "Preis";
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBoxProductCategory.Location = new System.Drawing.Point(81, 62);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(159, 21);
            this.comboBoxProductCategory.TabIndex = 8;
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.ForeColor = System.Drawing.Color.White;
            this.btnProductSave.Location = new System.Drawing.Point(81, 134);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(82, 23);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(345, 134);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(82, 23);
            this.btnProductDelete.TabIndex = 10;
            this.btnProductDelete.Text = "Löschen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductClear.ForeColor = System.Drawing.Color.White;
            this.btnProductClear.Location = new System.Drawing.Point(257, 134);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(82, 23);
            this.btnProductClear.TabIndex = 11;
            this.btnProductClear.Text = "Felder Leeren";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductEdit.ForeColor = System.Drawing.Color.White;
            this.btnProductEdit.Location = new System.Drawing.Point(169, 134);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(82, 23);
            this.btnProductEdit.TabIndex = 12;
            this.btnProductEdit.Text = "Bearbeiten";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowUserToAddRows = false;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(16, 163);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            this.productsDGV.RowHeadersVisible = false;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.productsDGV.RowTemplate.ReadOnly = true;
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(771, 286);
            this.productsDGV.TabIndex = 13;
            this.productsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellContentClick);
            // 
            // BtnProgramClose
            // 
            this.BtnProgramClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnProgramClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgramClose.ForeColor = System.Drawing.Color.White;
            this.BtnProgramClose.Location = new System.Drawing.Point(668, 11);
            this.BtnProgramClose.Name = "BtnProgramClose";
            this.BtnProgramClose.Size = new System.Drawing.Size(119, 23);
            this.BtnProgramClose.TabIndex = 14;
            this.BtnProgramClose.Text = "Programm verlassen";
            this.BtnProgramClose.UseVisualStyleBackColor = false;
            this.BtnProgramClose.Click += new System.EventHandler(this.BtnProgramClose_Click);
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.BtnProgramClose);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.LblPreis);
            this.Controls.Add(this.LblKategorie);
            this.Controls.Add(this.textBoxProductBrand);
            this.Controls.Add(this.LblMarke);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductBrand;
        private System.Windows.Forms.Label LblMarke;
        private System.Windows.Forms.Label LblKategorie;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label LblPreis;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.Button BtnProgramClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}