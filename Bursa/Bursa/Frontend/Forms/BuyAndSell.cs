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

            buycr.Visible = false;
            sellcr.Visible = false;
            buyst.Visible = false;
            sellst.Visible = false;

        }
    }
}
