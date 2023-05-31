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
using Bursa.Backend;

namespace Bursa
{


    public partial class MainForm : Form
    {

        static public Welcome welc = new Welcome();
        static public RegisterOrLogin reglog = new RegisterOrLogin();

        public static int btcprice;
        public static int ethprice;


        public MainForm()
        {
            InitializeComponent();

            panel1.Controls.Add(welc);
            panel1.Controls.Add(reglog);
            welc.Visible = false;
            BTCPrice.Hide();
            ETHPrice.Hide(); 
            HITPrice.Hide();
            ApplePrice.Hide();
            TeslaPrice.Hide();
            PfizerPrice.Hide();

            this.FormClosing += new FormClosingEventHandler(UserManager.SaveUsers);
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                OpenBuySell();
            }

        }

       public bool CheckIfLogged()
        {
  
            if (welc.Visible == true)
            {
                return true;
            }
            else 
            {
                MessageBox.Show("Can not access while not logged in.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

        }
        private void OpenBuySell()
        {
            if (CheckIfLogged())
            {
                BuyAndSell buysell = new BuyAndSell();
                buysell.ShowDialog();
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // ------------------------------------------ //
            // BTC PRICE //

            HttpClient client = new HttpClient();


            string responseContent = await client.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD");

            responseContent = responseContent.Substring(7, 5);

            int.TryParse(responseContent, out btcprice);

            BTCPrice.Text = responseContent + " $";
            BTCPrice.Show();
            ApplePrice.Show();


            // ------------------------------------------ //
            // ETH PRICE //

            HttpClient client2 = new HttpClient();

            string responseContent2 = await client2.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
            responseContent2 = responseContent2.Substring(7, 4);

            int.TryParse(responseContent2, out ethprice);

            ETHPrice.Text = responseContent2 + " $";
            ETHPrice.Show();
            TeslaPrice.Show();

            // ------------------------------------------ //

            HITPrice.Show();
            PfizerPrice.Show();

        }


    }
}
