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
    public partial class SellStocks : UserControl
    {
        readonly User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);

        public SellStocks()
        {
            InitializeComponent();
        }

        private void SellStocks_Load(object sender, EventArgs e)
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

                TeslaAM.Text = teslaAM.ToString();
                AppleAM.Text = appleAM.ToString();
                PfizerAM.Text = pfizerAM.ToString();

            }
        }

        private void SellTesla_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(TesAM.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TesAM.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(TesAM.Text) && int.Parse(TesAM.Text) >= 0)
            {
                if (targetUser.StocksPortfolio[0].Quantity >= int.Parse(TesAM.Text))
                {
                    targetUser.StocksPortfolio[0].Quantity -= int.Parse(TesAM.Text);
                    TesAM.Clear();
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
                MessageBox.Show("Invalid Number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SellApple_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(AppAM.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AppAM.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(AppAM.Text) && int.Parse(AppAM.Text) >= 0)
            {
                if (targetUser.StocksPortfolio[1].Quantity >= int.Parse(AppAM.Text))
                {
                    targetUser.StocksPortfolio[1].Quantity -= int.Parse(AppAM.Text);
                    AppAM.Clear();
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
                MessageBox.Show("Invalid Number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SellPfizer_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(PfizAM.Text, out int result))
            {
                MessageBox.Show("Invalid Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PfizAM.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(PfizAM.Text) && int.Parse(PfizAM.Text) >= 0)
            {
                if (targetUser.StocksPortfolio[2].Quantity >= int.Parse(PfizAM.Text))
                {
                    targetUser.StocksPortfolio[2].Quantity -= int.Parse(PfizAM.Text);
                    PfizAM.Clear();
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
                MessageBox.Show("Invalid Number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
