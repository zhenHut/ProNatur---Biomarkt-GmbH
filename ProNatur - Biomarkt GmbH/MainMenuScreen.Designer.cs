namespace ProNatur___Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProduct
            // 
            this.BtnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProduct.BackgroundImage")));
            this.BtnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduct.ForeColor = System.Drawing.Color.White;
            this.BtnProduct.Location = new System.Drawing.Point(12, 30);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(275, 125);
            this.BtnProduct.TabIndex = 0;
            this.BtnProduct.Text = "Produkte Verwalten";
            this.BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnBill
            // 
            this.BtnBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBill.BackgroundImage")));
            this.BtnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBill.ForeColor = System.Drawing.Color.White;
            this.BtnBill.Location = new System.Drawing.Point(333, 30);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(275, 125);
            this.BtnBill.TabIndex = 1;
            this.BtnBill.Text = "Rechnung erstellen";
            this.BtnBill.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(620, 201);
            this.Controls.Add(this.BtnBill);
            this.Controls.Add(this.BtnProduct);
            this.Name = "MainMenuScreen";
            this.Text = "MainMenuScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnBill;
    }
}