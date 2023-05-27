using Bursa.Frontend.UserControls;
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
    public partial class BuyAndSell : Form
    {
        static public BuyCrypto buycr = new BuyCrypto();
        static public SellCrypto sellcr = new SellCrypto();
        static public BuyStocks buyst = new BuyStocks();
        static public SellStocks sellst = new SellStocks();

        public BuyAndSell()
        {
            InitializeComponent();

            BuySellPanel.Controls.Add(buycr);
            BuySellPanel.Controls.Add(sellcr);
            BuySellPanel.Controls.Add(buyst);
            BuySellPanel.Controls.Add(sellst);


            //buycr.Visible = false;
            //sellcr.Visible = false;
            //buyst.Visible = false;
            //sellst.Visible = false;

            BuySellPanel.Visible = false;

        }

        private void SellButton_Click(object sender, EventArgs e)
        {

            if (BuyOrSellBox.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a category.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (BuyOrSellBox.SelectedItem.ToString() == "Cryptocurrency")
            {
                sellcr.BringToFront();
                sellcr.UpdatePrices();

                BuySellPanel.Visible = true;

            }
            else if (BuyOrSellBox.SelectedItem.ToString() == "Stocks")
            {
                sellst.BringToFront();
                sellst.UpdatePrices();

                BuySellPanel.Visible = true;

            }
           
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (BuyOrSellBox.SelectedIndex == -1)
            {
                  
                MessageBox.Show("Please select a category.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }

            if (BuyOrSellBox.SelectedItem.ToString() == "Cryptocurrency")
            {
                buycr.BringToFront();
                buycr.UpdatePrices();

                BuySellPanel.Visible = true;

            }
            else if (BuyOrSellBox.SelectedItem.ToString() == "Stocks")
            {
                buyst.BringToFront();
                buyst.UpdatePrices();

                BuySellPanel.Visible = true;

            }
          
        }
    }
}
