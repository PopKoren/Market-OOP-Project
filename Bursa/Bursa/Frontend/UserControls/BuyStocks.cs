using Bursa.Backend;
using Bursa.Backend.Models;
using Bursa.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Frontend.UserControls
{
    public partial class BuyStocks : UserControl
    {
        User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);

        public BuyStocks()
        {
            InitializeComponent();
        }

        private void BuyStocks_Load(object sender, EventArgs e)
        {
            UpdatePrices();
        }
        public void UpdatePrices()
        {
            if (targetUser != null)
            {
                int teslaAM = targetUser.StocksPortfolio[0].Quantity;
                int appleAM = targetUser.StocksPortfolio[1].Quantity;
                int pfizerAM = targetUser.StocksPortfolio[2].Quantity;

                TeslaPR.Text = teslaAM.ToString();
                ApplePR.Text = appleAM.ToString();
                PfizerPR.Text = pfizerAM.ToString();

            }
        }
        private void BuyTesla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TeslaAm.Text))
            {
                targetUser.StocksPortfolio[0].Quantity += int.Parse(TeslaAm.Text);
                TeslaAm.Clear();
                UpdatePrices();
                MessageBox.Show("Successfully Purchase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Wrong Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BuyApple_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AppleAm.Text))
            {
                targetUser.StocksPortfolio[1].Quantity += int.Parse(AppleAm.Text);
                AppleAm.Clear();
                UpdatePrices();

                MessageBox.Show("Successfully Purchase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Wrong Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BuyPfizer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PfizerAm.Text))
            {
                targetUser.StocksPortfolio[2].Quantity += int.Parse(PfizerAm.Text);
                PfizerAm.Clear();
                UpdatePrices();

                MessageBox.Show("Successfully Purchase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Wrong Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

      
    }
}
