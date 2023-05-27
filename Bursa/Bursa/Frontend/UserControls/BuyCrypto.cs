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
    public partial class BuyCrypto : UserControl
    {

        User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);


        public BuyCrypto()
        {
            InitializeComponent();

        }

        private void BuyCrypto_Load(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        public void UpdatePrices()
        {
            if (targetUser != null)
            {
                int btcamount = targetUser.CryptoPortfolio[0].Quantity;
                int ethamount = targetUser.CryptoPortfolio[1].Quantity;
                int hitamount = targetUser.CryptoPortfolio[2].Quantity;

                BTCam.Text = btcamount.ToString();
                ETHam.Text = ethamount.ToString();
                HITam.Text = hitamount.ToString();

            }
        }
        
        private void BuyBTC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BTCamount.Text))
            {
                targetUser.CryptoPortfolio[0].Quantity += int.Parse(BTCamount.Text);
                BTCamount.Clear();
                UpdatePrices();
                MessageBox.Show("Successfully Purchase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Wrong Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BuyETH_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ETHamount.Text))
            {
                targetUser.CryptoPortfolio[1].Quantity += int.Parse(ETHamount.Text);
                ETHamount.Clear();
                UpdatePrices();
                MessageBox.Show("Successfully Purchase", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Wrong Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BuyHIT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HITamount.Text))
            {
                targetUser.CryptoPortfolio[2].Quantity += int.Parse(HITamount.Text);
                HITamount.Clear();
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
