namespace Bursa.Frontend.Forms
{
    partial class UserProfile
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
            this.UserProfileView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deleteAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserProfileView
            // 
            this.UserProfileView.AllowUserToAddRows = false;
            this.UserProfileView.AllowUserToDeleteRows = false;
            this.UserProfileView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserProfileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserProfileView.Location = new System.Drawing.Point(47, 143);
            this.UserProfileView.Name = "UserProfileView";
            this.UserProfileView.ReadOnly = true;
            this.UserProfileView.Size = new System.Drawing.Size(723, 173);
            this.UserProfileView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLabel.Location = new System.Drawing.Point(586, 54);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(184, 25);
            this.HelloLabel.TabIndex = 2;
            this.HelloLabel.Text = "Hello *username*!";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cryptocurrency",
            "Stocks"});
            this.comboBox1.Location = new System.Drawing.Point(47, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteAcc
            // 
            this.deleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAcc.Location = new System.Drawing.Point(619, 376);
            this.deleteAcc.Name = "deleteAcc";
            this.deleteAcc.Size = new System.Drawing.Size(151, 47);
            this.deleteAcc.TabIndex = 4;
            this.deleteAcc.Text = "Delete Account";
            this.deleteAcc.UseVisualStyleBackColor = true;
            this.deleteAcc.Click += new System.EventHandler(this.deleteAcc_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteAcc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserProfileView);
            this.Name = "UserProfile";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserProfileView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserProfileView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteAcc;
    }
}