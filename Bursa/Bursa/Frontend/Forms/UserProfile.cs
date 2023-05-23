using Bursa.Backend;
using Bursa.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Frontend.Forms
{
    public partial class UserProfile : Form
    {
        private List<Crypto> CryptoPortfolio;
        private List<Stock> StocksPortfolio;


        public UserProfile()
        {
            InitializeComponent();

            // Create an instance of each class

            Bitcoin btc = new Bitcoin(0);   
            Etherium eth = new Etherium( 0, MainForm.ethprice);
            HIT hit = new HIT(0, 1);

            Tesla tesla = new Tesla(0, 200);
            Pfizer pfizer = new Pfizer(0, 40);

            // Initialize the data list and add instances
            CryptoPortfolio = new List<Crypto>();

            CryptoPortfolio.Add(btc);
            CryptoPortfolio.Add(eth);
            CryptoPortfolio.Add(hit);

            StocksPortfolio = new List<Stock>();
            StocksPortfolio.Add(tesla);
            StocksPortfolio.Add(pfizer);


            //UserProfileView.DataSource = UserManager.GetUsers();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MainForm.reglog.Visible = true;
            MainForm.reglog.BringToFront();
            MainForm.welc.Visible = false;

            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Cryptocurrency")
            {
                UserProfileView.DataSource = CryptoPortfolio;
            }
            else if (comboBox1.SelectedItem.ToString() == "Stocks")
            {
                UserProfileView.DataSource = StocksPortfolio;
            }
        }
    }
}
