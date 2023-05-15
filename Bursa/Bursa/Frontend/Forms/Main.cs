using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bursa.Frontend.Forms;
using Bursa.Frontend.UserControls;
using System.Net.Http;


namespace Bursa
{
    public partial class MainForm : Form
    {
        public MainForm(bool logged = false)
        {
            InitializeComponent();

            if (logged)
            {
                _ = new Welcome
                {
                    Visible = true
                };
            }
            else
            {
                _ = new RegisterOrLogin
                {
                    Visible = true
                };
            }

            BTCPrice.Hide();
            ETHPrice.Hide();
            HITPrice.Hide();

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            BuySell buysell = new BuySell();
            buysell.Show();
        }

       
        private async void MainForm_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            string responseContent = await client.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD");
            responseContent = responseContent.Replace("}", " ");
            responseContent = responseContent.Remove(0, 7);

            BTCPrice.Text = responseContent;
            BTCPrice.Show();

            // ------------------------------------ //

            HttpClient client2 = new HttpClient();

            string responseContent2 = await client2.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
            responseContent2 = responseContent2.Replace("}", " ");
            responseContent2 = responseContent2.Remove(0, 7);

            ETHPrice.Text = responseContent2;
            ETHPrice.Show();
            HITPrice.Show();

        }
    }
}
