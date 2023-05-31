
namespace Bursa.Frontend.Forms
{
    partial class Signature
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
            this.Button1 = new System.Windows.Forms.Button();
            this.signaturePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.signaturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(239, 337);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(107, 37);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Done";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // signaturePictureBox
            // 
            this.signaturePictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.signaturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signaturePictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.signaturePictureBox.InitialImage = null;
            this.signaturePictureBox.Location = new System.Drawing.Point(32, 67);
            this.signaturePictureBox.Name = "signaturePictureBox";
            this.signaturePictureBox.Size = new System.Drawing.Size(551, 248);
            this.signaturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.signaturePictureBox.TabIndex = 2;
            this.signaturePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign to confirm:";
            // 
            // Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.signaturePictureBox);
            this.Name = "Signature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signature";
            ((System.ComponentModel.ISupportInitialize)(this.signaturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox signaturePictureBox;
        private System.Windows.Forms.Label label1;
    }
}