using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pen myPan = new Pen(Color.Black, 1);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.DrawLine(myPan, 10, 80, 20, 80);
            g.DrawLine(myPan, 20, 80, 20, 70);
            g.DrawLine(myPan, 20, 70, 30, 70);
            g.DrawLine(myPan, 30, 70, 30, 60);
            g.DrawLine(myPan, 30, 60, 40, 60);
            g.DrawLine(myPan, 40, 60, 40, 50);
            g.DrawLine(myPan, 40, 50, 60, 50);
            g.DrawLine(myPan, 60, 50, 60, 40);
            g.DrawLine(myPan, 60, 40, 80, 40);
            g.DrawLine(myPan, 80, 40, 80, 20);
            g.DrawLine(myPan, 80, 20, 170, 20);
            g.DrawLine(myPan, 170, 20, 170, 40);
            g.DrawLine(myPan, 170, 40, 190, 40);
            g.DrawLine(myPan, 190, 40, 190, 50);
            g.DrawLine(myPan, 190, 50, 210, 50);
            g.DrawLine(myPan, 210, 50, 210, 70);
            g.DrawLine(myPan, 210, 70, 230, 70);
            g.DrawLine(myPan, 230, 70, 230, 60);
            g.DrawLine(myPan, 230, 60, 250, 60);
            g.DrawLine(myPan, 250, 60, 250, 40);
            g.DrawLine(myPan, 250, 40, 270, 40);
            g.DrawLine(myPan, 270, 40, 270, 70);
            g.DrawLine(myPan, 270, 70, 260, 70);
            g.DrawLine(myPan, 260, 70, 260, 80);
            g.DrawLine(myPan, 260, 80, 250, 80);
            g.DrawLine(myPan, 250, 80, 250, 100);
            g.DrawLine(myPan, 250, 100, 260, 100);
            g.DrawLine(myPan, 260, 100, 260, 110);
            g.DrawLine(myPan, 260, 110, 270, 110);
            g.DrawLine(myPan, 270, 110, 270, 130);
            g.DrawLine(myPan, 270, 130, 250, 130);
            g.DrawLine(myPan, 250, 130, 250, 120);
            g.DrawLine(myPan, 250, 120, 240, 120);
            g.DrawLine(myPan, 240, 120, 240, 110);
            g.DrawLine(myPan, 240, 110, 230, 110);
            g.DrawLine(myPan, 230, 110, 230, 100);
            g.DrawLine(myPan, 230, 100, 210, 100);
            g.DrawLine(myPan, 210, 100, 210, 110);
            g.DrawLine(myPan, 210, 110, 200, 110);
            g.DrawLine(myPan, 200, 110, 200, 120);
            g.DrawLine(myPan, 200, 120, 180, 120);
            g.DrawLine(myPan, 180, 120, 180, 130);
            g.DrawLine(myPan, 180, 130, 160, 130);
            g.DrawLine(myPan, 160, 130, 160, 140);
            g.DrawLine(myPan, 160, 140, 80, 140);
            g.DrawLine(myPan, 80, 140, 80, 130);
            g.DrawLine(myPan, 80, 130, 60, 130);
            g.DrawLine(myPan, 60, 130, 60, 120);
            g.DrawLine(myPan, 60, 120, 40, 120);
            g.DrawLine(myPan, 40, 120, 40, 110);
            g.DrawLine(myPan, 40, 110, 20, 110);
            g.DrawLine(myPan, 20, 110, 20, 100);
            g.DrawLine(myPan, 20, 100, 10, 100);
            g.DrawLine(myPan, 10, 100, 10, 80);
            g.DrawRectangle(myPan, 60, 70, 10, 10);
        }
    }
}
