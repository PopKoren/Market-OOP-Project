
namespace Bursa.Frontend.Forms
{
    partial class BuyAndSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuyOrSellBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BuySellPanel = new System.Windows.Forms.Panel();
            this.buyCrypto1 = new Bursa.Frontend.UserControls.BuyCrypto();
            this.buyStock1 = new Bursa.Frontend.UserControls.BuyStocks();
            this.sellCrypto1 = new Bursa.Frontend.UserControls.SellCrypto();
            this.sellStock1 = new Bursa.Frontend.UserControls.SellStocks();
            this.BuySellPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyOrSellBox
            // 
            this.BuyOrSellBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyOrSellBox.FormattingEnabled = true;
            this.BuyOrSellBox.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.BuyOrSellBox.Location = new System.Drawing.Point(22, 53);
            this.BuyOrSellBox.Name = "BuyOrSellBox";
            this.BuyOrSellBox.Size = new System.Drawing.Size(180, 32);
            this.BuyOrSellBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sell";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BuySellPanel
            // 
            this.BuySellPanel.Controls.Add(this.sellStock1);
            this.BuySellPanel.Controls.Add(this.sellCrypto1);
            this.BuySellPanel.Controls.Add(this.buyStock1);
            this.BuySellPanel.Controls.Add(this.buyCrypto1);
            this.BuySellPanel.Location = new System.Drawing.Point(236, 36);
            this.BuySellPanel.Name = "BuySellPanel";
            this.BuySellPanel.Size = new System.Drawing.Size(537, 385);
            this.BuySellPanel.TabIndex = 3;
            // 
            // buyCrypto1
            // 
            this.buyCrypto1.Location = new System.Drawing.Point(3, 29);
            this.buyCrypto1.Name = "buyCrypto1";
            this.buyCrypto1.Size = new System.Drawing.Size(504, 295);
            this.buyCrypto1.TabIndex = 0;
            // 
            // buyStock1
            // 
            this.buyStock1.Location = new System.Drawing.Point(0, 29);
            this.buyStock1.Name = "buyStock1";
            this.buyStock1.Size = new System.Drawing.Size(534, 299);
            this.buyStock1.TabIndex = 1;
            // 
            // sellCrypto1
            // 
            this.sellCrypto1.Location = new System.Drawing.Point(3, 59);
            this.sellCrypto1.Name = "sellCrypto1";
            this.sellCrypto1.Size = new System.Drawing.Size(408, 269);
            this.sellCrypto1.TabIndex = 2;
            // 
            // sellStock1
            // 
            this.sellStock1.Location = new System.Drawing.Point(3, 54);
            this.sellStock1.Name = "sellStock1";
            this.sellStock1.Size = new System.Drawing.Size(486, 274);
            this.sellStock1.TabIndex = 3;
            // 
            // BuyAndSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuySellPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuyOrSellBox);
            this.Name = "BuyAndSell";
            this.Text = "Form1";
            this.BuySellPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BuyOrSellBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel BuySellPanel;
        private UserControls.SellStocks sellStock1;
        private UserControls.SellCrypto sellCrypto1;
        private UserControls.BuyStocks buyStock1;
        private UserControls.BuyCrypto buyCrypto1;
    }
}