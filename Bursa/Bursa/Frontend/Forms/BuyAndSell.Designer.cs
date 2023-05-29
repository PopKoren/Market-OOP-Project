
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.BuySellPanel = new System.Windows.Forms.Panel();
            this.sellStocks1 = new Bursa.Frontend.UserControls.SellStocks();
            this.sellCrypto1 = new Bursa.Frontend.UserControls.SellCrypto();
            this.buyStocks1 = new Bursa.Frontend.UserControls.BuyStocks();
            this.buyCrypto1 = new Bursa.Frontend.UserControls.BuyCrypto();
            this.BuySellPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyOrSellBox
            // 
            this.BuyOrSellBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyOrSellBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyOrSellBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyOrSellBox.FormattingEnabled = true;
            this.BuyOrSellBox.Items.AddRange(new object[] {
            "Cryptocurrency",
            "Stocks"});
            this.BuyOrSellBox.Location = new System.Drawing.Point(22, 53);
            this.BuyOrSellBox.Name = "BuyOrSellBox";
            this.BuyOrSellBox.Size = new System.Drawing.Size(180, 32);
            this.BuyOrSellBox.TabIndex = 0;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(22, 163);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(130, 70);
            this.BuyButton.TabIndex = 1;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(22, 290);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(130, 70);
            this.SellButton.TabIndex = 2;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // BuySellPanel
            // 
            this.BuySellPanel.Controls.Add(this.sellStocks1);
            this.BuySellPanel.Controls.Add(this.sellCrypto1);
            this.BuySellPanel.Controls.Add(this.buyStocks1);
            this.BuySellPanel.Controls.Add(this.buyCrypto1);
            this.BuySellPanel.Location = new System.Drawing.Point(236, 36);
            this.BuySellPanel.Name = "BuySellPanel";
            this.BuySellPanel.Size = new System.Drawing.Size(537, 385);
            this.BuySellPanel.TabIndex = 3;
            // 
            // sellStocks1
            // 
            this.sellStocks1.Location = new System.Drawing.Point(3, 3);
            this.sellStocks1.Name = "sellStocks1";
            this.sellStocks1.Size = new System.Drawing.Size(537, 385);
            this.sellStocks1.TabIndex = 3;
            // 
            // sellCrypto1
            // 
            this.sellCrypto1.Location = new System.Drawing.Point(-13, -3);
            this.sellCrypto1.Name = "sellCrypto1";
            this.sellCrypto1.Size = new System.Drawing.Size(534, 382);
            this.sellCrypto1.TabIndex = 2;
            // 
            // buyStocks1
            // 
            this.buyStocks1.Location = new System.Drawing.Point(-3, 0);
            this.buyStocks1.Name = "buyStocks1";
            this.buyStocks1.Size = new System.Drawing.Size(537, 379);
            this.buyStocks1.TabIndex = 1;
            // 
            // buyCrypto1
            // 
            this.buyCrypto1.Location = new System.Drawing.Point(0, 3);
            this.buyCrypto1.Name = "buyCrypto1";
            this.buyCrypto1.Size = new System.Drawing.Size(537, 379);
            this.buyCrypto1.TabIndex = 0;
            // 
            // BuyAndSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuySellPanel);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.BuyOrSellBox);
            this.Name = "BuyAndSell";
            this.Text = "Buy and Sell";
            this.BuySellPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BuyOrSellBox;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Panel BuySellPanel;
        private UserControls.SellStocks sellStocks1;
        private UserControls.SellCrypto sellCrypto1;
        private UserControls.BuyStocks buyStocks1;
        private UserControls.BuyCrypto buyCrypto1;
    }
}