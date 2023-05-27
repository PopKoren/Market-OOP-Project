using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]
    public class User
    {

        public BindingList<Crypto> CryptoPortfolio { get; set; } =  new BindingList<Crypto>();
        public BindingList<Stock> StocksPortfolio { get; set; } = new BindingList<Stock>();

        public string Username { get; set; }
        public string Password { get; set; }
        public string Dateofbirth { get; set; }
        public string Email { get; set; }
        public double TotalBalance { get; set; }

        public User(string username, string password, DateTime dateofbirth, string email, double balance = 0)
        {
            Username = username;
            Password = password;
            Dateofbirth = dateofbirth.ToShortDateString();
            Email = email;
            TotalBalance = balance;


            Bitcoin btc = new Bitcoin(0);
            Etherium eth = new Etherium(0);
            HIT hit = new HIT(0);

            Tesla tesla = new Tesla(0);
            Apple apple = new Apple(0);
            Pfizer pfizer = new Pfizer(0);

            // Initialize the data list and add instances

            CryptoPortfolio.Add(btc);
            CryptoPortfolio.Add(eth);
            CryptoPortfolio.Add(hit);

            StocksPortfolio.Add(tesla);
            StocksPortfolio.Add(apple);
            StocksPortfolio.Add(pfizer);



        }

        public BindingList<Crypto> GetCrypto()
        {
            return CryptoPortfolio;
        }
        public BindingList<Stock> GetStocks()
        {
            return StocksPortfolio;
        }

    }
}
