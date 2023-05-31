
namespace Bursa.Frontend.UserControls
{
    partial class SellCrypto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellCrypto));
            this.Sellbtc = new System.Windows.Forms.Button();
            this.SellETH = new System.Windows.Forms.Button();
            this.SellHIT = new System.Windows.Forms.Button();
            this.HITam = new System.Windows.Forms.Label();
            this.ETHam = new System.Windows.Forms.Label();
            this.BTCam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HITbox = new System.Windows.Forms.TextBox();
            this.ETHbox = new System.Windows.Forms.TextBox();
            this.BTCbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sellbtc
            // 
            this.Sellbtc.Location = new System.Drawing.Point(412, 109);
            this.Sellbtc.Name = "Sellbtc";
            this.Sellbtc.Size = new System.Drawing.Size(75, 23);
            this.Sellbtc.TabIndex = 38;
            this.Sellbtc.Text = "Sell";
            this.Sellbtc.UseVisualStyleBackColor = true;
            this.Sellbtc.Click += new System.EventHandler(this.Sellbtc_Click);
            // 
            // SellETH
            // 
            this.SellETH.Location = new System.Drawing.Point(412, 152);
            this.SellETH.Name = "SellETH";
            this.SellETH.Size = new System.Drawing.Size(75, 23);
            this.SellETH.TabIndex = 39;
            this.SellETH.Text = "Sell";
            this.SellETH.UseVisualStyleBackColor = true;
            this.SellETH.Click += new System.EventHandler(this.SellETH_Click);
            // 
            // SellHIT
            // 
            this.SellHIT.Location = new System.Drawing.Point(412, 195);
            this.SellHIT.Name = "SellHIT";
            this.SellHIT.Size = new System.Drawing.Size(75, 23);
            this.SellHIT.TabIndex = 40;
            this.SellHIT.Text = "Sell";
            this.SellHIT.UseVisualStyleBackColor = true;
            this.SellHIT.Click += new System.EventHandler(this.SellHIT_Click);
            // 
            // HITam
            // 
            this.HITam.AutoSize = true;
            this.HITam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HITam.Location = new System.Drawing.Point(232, 202);
            this.HITam.Name = "HITam";
            this.HITam.Size = new System.Drawing.Size(51, 20);
            this.HITam.TabIndex = 59;
            this.HITam.Text = "label6";
            // 
            // ETHam
            // 
            this.ETHam.AutoSize = true;
            this.ETHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETHam.Location = new System.Drawing.Point(232, 154);
            this.ETHam.Name = "ETHam";
            this.ETHam.Size = new System.Drawing.Size(51, 20);
            this.ETHam.TabIndex = 58;
            this.ETHam.Text = "label5";
            // 
            // BTCam
            // 
            this.BTCam.AutoSize = true;
            this.BTCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCam.Location = new System.Drawing.Point(231, 109);
            this.BTCam.Name = "BTCam";
            this.BTCam.Size = new System.Drawing.Size(27, 20);
            this.BTCam.TabIndex = 57;
            this.BTCam.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "HIT  - Available amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "ETH  - Available amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 40);
            this.label2.TabIndex = 54;
            this.label2.Text = "BTC  - Available amount\r\n\r\n";
            // 
            // HITbox
            // 
            this.HITbox.Location = new System.Drawing.Point(292, 197);
            this.HITbox.Name = "HITbox";
            this.HITbox.Size = new System.Drawing.Size(100, 20);
            this.HITbox.TabIndex = 53;
            // 
            // ETHbox
            // 
            this.ETHbox.Location = new System.Drawing.Point(292, 151);
            this.ETHbox.Name = "ETHbox";
            this.ETHbox.Size = new System.Drawing.Size(100, 20);
            this.ETHbox.TabIndex = 52;
            // 
            // BTCbox
            // 
            this.BTCbox.Location = new System.Drawing.Point(292, 108);
            this.BTCbox.Name = "BTCbox";
            this.BTCbox.Size = new System.Drawing.Size(100, 20);
            this.BTCbox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 51);
            this.label1.TabIndex = 60;
            // 
            // SellCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HITam);
            this.Controls.Add(this.ETHam);
            this.Controls.Add(this.BTCam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HITbox);
            this.Controls.Add(this.ETHbox);
            this.Controls.Add(this.BTCbox);
            this.Controls.Add(this.SellHIT);
            this.Controls.Add(this.SellETH);
            this.Controls.Add(this.Sellbtc);
            this.Name = "SellCrypto";
            this.Size = new System.Drawing.Size(521, 269);
            this.Load += new System.EventHandler(this.SellCrypto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sellbtc;
        private System.Windows.Forms.Button SellETH;
        private System.Windows.Forms.Button SellHIT;
        private System.Windows.Forms.Label HITam;
        private System.Windows.Forms.Label ETHam;
        private System.Windows.Forms.Label BTCam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HITbox;
        private System.Windows.Forms.TextBox ETHbox;
        private System.Windows.Forms.TextBox BTCbox;
        private System.Windows.Forms.Label label1;
    }
}
