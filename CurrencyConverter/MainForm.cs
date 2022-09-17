using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class MainForm : Form
    {
        CurrencyConverter currencyConverter;
        public MainForm()
        {
            InitializeComponent();
            currencyConverter = new CurrencyConverter();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string fromCurrencySymbol = ((KeyValuePair<string, string>)cmbFromCurrency.SelectedItem).Key;
            string toCurrencySymbol = ((KeyValuePair<string, string>)cmbToCurrency.SelectedItem).Key;
            double currencyAmount = double.Parse(txtFromCurrency.Text);
            double finalValue = currencyConverter.Convert(fromCurrencySymbol,toCurrencySymbol, currencyAmount);
            txtToCurrency.Text = finalValue.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> symbolData = currencyConverter.GetSymbols();
            cmbFromCurrency.Items.Clear();
            cmbToCurrency.Items.Clear();

            cmbFromCurrency.DataSource = new BindingSource(symbolData, null);
            cmbFromCurrency.DisplayMember = "Value";
            cmbFromCurrency.ValueMember = "Key";


            cmbToCurrency.DataSource = new BindingSource(symbolData, null);
            cmbToCurrency.DisplayMember = "Value";
            cmbToCurrency.ValueMember = "Key";


            if (symbolData.Keys.Count > 1)
            {
                cmbFromCurrency.SelectedIndex = 0;
                cmbToCurrency.SelectedIndex = 1;
            }
            
        }
    }
}
