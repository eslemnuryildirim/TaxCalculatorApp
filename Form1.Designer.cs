namespace TaxCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli designer değişkenleri
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan kaynakları temizleme
        /// </summary>
        /// <param name="disposing">Kaynakları temizle</param>
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
        /// Designer desteği için gerekli metot
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(120, 30);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(150, 21);
            this.cmbCountry.TabIndex = 0;

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(120, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 20);
            this.txtAmount.TabIndex = 1;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(120, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(120, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Vergi Miktarı:";

            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 30);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 13);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Ülke Seçin:";

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 70);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 13);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Tutar Girin:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbCountry);
            this.Name = "Form1";
            this.Text = "Vergi Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAmount;
    }
}
