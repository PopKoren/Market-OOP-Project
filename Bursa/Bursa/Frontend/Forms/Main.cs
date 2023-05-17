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

        public MainForm()
        {
            InitializeComponent();

            panel1.Controls.Add(welc);
            panel1.Controls.Add(reglog);
            welc.Visible = false;

            //ShowRegisterOrLogin();

            BTCPrice.Hide();
            ETHPrice.Hide(); 
            HITPrice.Hide();

            this.FormClosing += new FormClosingEventHandler(UserManager.SaveUsers);
        }

        //public void ShowWelcome()
        //{
        //    welcome2.Visible = true;
        //    registerOrLogin2.Visible = false;

        //}

        //public void ShowRegisterOrLogin()
        //{
        //    welcome2.Visible = false;
        //    registerOrLogin2.Visible = true;
        //}

       
        private void Label4_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BuySell buysell = new BuySell();
                buysell.ShowDialog();
            }

        }

       public bool CheckIfLogged()
        {

            //bool isUserControlVisible = false;

            //foreach (Control control in panel1.Controls)
            //{
            //    if (control == welc && control.Visible)
            //    {
            //        // userControl1 is visible
            //        isUserControlVisible = true;
            //        break;
            //    }
            //}

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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // ------------------------------------------ //
            // BTC PRICE //

            HttpClient client = new HttpClient();


            string responseContent = await client.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=BTC&tsyms=USD");

            responseContent = responseContent.Replace("}", " ");
            responseContent = responseContent.Remove(0, 7);

            BTCPrice.Text = responseContent;
            BTCPrice.Show();

            // ------------------------------------------ //
            // ETH PRICE //

            HttpClient client2 = new HttpClient();

            string responseContent2 = await client2.GetStringAsync("https://min-api.cryptocompare.com/data/price?fsym=ETH&tsyms=USD");
            responseContent2 = responseContent2.Replace("}", " ");
            responseContent2 = responseContent2.Remove(0, 7);

            ETHPrice.Text = responseContent2;
            ETHPrice.Show();
            // ------------------------------------------ //

            HITPrice.Show();

           
        }


    }
}
