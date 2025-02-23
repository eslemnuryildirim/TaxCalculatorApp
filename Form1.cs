using System;
using System.Windows.Forms;
using TaxCalculatorApp.Strategies;
using TaxCalculatorApp.Strategies.TaxCalculatorApp.Strategies;

namespace TaxCalculatorApp
{
    public partial class Form1 : Form
    {
        private readonly TaxContext _taxContext;

        public Form1()
        {
            InitializeComponent();
            _taxContext = new TaxContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kod
            cmbCountry.Items.Add("Türkiye");
            cmbCountry.Items.Add("ABD");
            cmbCountry.Items.Add("Avrupa");
            cmbCountry.SelectedIndex = 0; // Varsayılan ülke Türkiye olsun
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ülke seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen ülkeye göre strateji belirle
            switch (cmbCountry.SelectedItem.ToString())
            {
                case "Türkiye":
                    _taxContext.SetTaxStrategy(new TurkeyTax());
                    break;
                case "ABD":
                    _taxContext.SetTaxStrategy(new USATax());
                    break;
                case "Avrupa":
                    _taxContext.SetTaxStrategy(new EuropeTax());
                    break;
                default:
                    MessageBox.Show("Geçersiz seçim!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Vergiyi hesapla ve sonucu göster
            decimal tax = _taxContext.CalculateTax(amount);
            lblResult.Text = $"Vergi Miktarı: {tax:C}";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Eğer bu olayı kullanmıyorsan, Designer'dan da kaldırabilirsin.
        }
    }
}
