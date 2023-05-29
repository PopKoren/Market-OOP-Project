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

    public partial class SellCrypto : UserControl
    {
        readonly User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);

        public SellCrypto()
        {
            InitializeComponent();
        }

        private void SellCrypto_Load(object sender, EventArgs e)
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

        private void Sellbtc_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(BTCbox.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BTCbox.Clear();
                return;

            }

            if (!string.IsNullOrEmpty(BTCbox.Text))
            {
                if (targetUser.CryptoPortfolio[0].Quantity >= int.Parse(BTCbox.Text) && int.Parse(BTCbox.Text) >= 0)
                {
                    targetUser.CryptoPortfolio[0].Quantity -= int.Parse(BTCbox.Text);
                    BTCbox.Clear();
                    UpdatePrices();
                    MessageBox.Show("Successfully Sold", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Not enough owned.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SellETH_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(ETHbox.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ETHbox.Clear();
                return;

            }
            if (!string.IsNullOrEmpty(ETHbox.Text))
            {
                if (targetUser.CryptoPortfolio[1].Quantity >= int.Parse(ETHbox.Text) && int.Parse(ETHbox.Text) >= 0)
                {
                    targetUser.CryptoPortfolio[1].Quantity -= int.Parse(ETHbox.Text);
                    ETHbox.Clear();
                    UpdatePrices();
                    MessageBox.Show("Successfully Sold", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Not enough owned.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SellHIT_Click(object sender, EventArgs e)
        {
         
            if (!int.TryParse(HITbox.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HITbox.Clear();
                return;

            }
            if (!string.IsNullOrEmpty(HITbox.Text))
            {
                if (targetUser.CryptoPortfolio[2].Quantity >= int.Parse(HITbox.Text) && int.Parse(HITbox.Text) >= 0)
                {
                    targetUser.CryptoPortfolio[2].Quantity -= int.Parse(HITbox.Text);
                    HITbox.Clear();
                    UpdatePrices();
                    MessageBox.Show("Successfully Sold", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Not enough owned.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
