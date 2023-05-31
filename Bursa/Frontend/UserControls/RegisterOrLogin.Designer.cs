
namespace Bursa.Frontend.UserControls
{
    partial class RegisterOrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterOrLogin));
            this.RegorLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegorLogButton
            // 
            this.RegorLogButton.BackColor = System.Drawing.Color.Silver;
            this.RegorLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegorLogButton.Image = ((System.Drawing.Image)(resources.GetObject("RegorLogButton.Image")));
            this.RegorLogButton.Location = new System.Drawing.Point(12, 16);
            this.RegorLogButton.Name = "RegorLogButton";
            this.RegorLogButton.Size = new System.Drawing.Size(163, 109);
            this.RegorLogButton.TabIndex = 2;
            this.RegorLogButton.Text = " ";
            this.RegorLogButton.UseVisualStyleBackColor = false;
            this.RegorLogButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RegisterOrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.RegorLogButton);
            this.Name = "RegisterOrLogin";
            this.Size = new System.Drawing.Size(178, 144);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegorLogButton;
    }
}
