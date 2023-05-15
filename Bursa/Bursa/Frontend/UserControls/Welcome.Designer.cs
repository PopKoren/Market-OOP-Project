namespace Bursa.Frontend.UserControls
{
    partial class Welcome
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
            this.WelcomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeButton
            // 
            this.WelcomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeButton.Location = new System.Drawing.Point(12, 17);
            this.WelcomeButton.Name = "WelcomeButton";
            this.WelcomeButton.Size = new System.Drawing.Size(156, 107);
            this.WelcomeButton.TabIndex = 0;
            this.WelcomeButton.Text = "Welcome!\r\nClick for Profile";
            this.WelcomeButton.UseVisualStyleBackColor = true;
            this.WelcomeButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WelcomeButton);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(184, 141);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WelcomeButton;
    }
}
