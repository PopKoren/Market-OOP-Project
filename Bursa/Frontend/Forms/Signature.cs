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
    public partial class Signature : Form
    {
        public bool isDrawing = false;
        private Point previousPoint;

        public Signature()
        {
            InitializeComponent();
            signaturePictureBox.MouseDown += SignaturePictureBox_MouseDown;
            signaturePictureBox.MouseMove += SignaturePictureBox_MouseMove;
            signaturePictureBox.MouseUp += SignaturePictureBox_MouseUp;

        }



        private void Button1_Click(object sender, EventArgs e)
        {
           
           this.Close();

        }


        private void SignaturePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void SignaturePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (Graphics g = signaturePictureBox.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
            isDrawing = true;

        }

        private void SignaturePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

        }
      

    }

}
