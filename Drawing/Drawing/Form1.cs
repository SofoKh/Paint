using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Pen myPen1 = new Pen(Color.White);
            Brush brush = new SolidBrush(Color.Red);
            Brush brush1 = new SolidBrush(Color.White);
            ///g.DrawLine(myPen, 100, 100, this.Width/2, this.Height/2);
            Rectangle r = new Rectangle(0,0,200,100);
            g.DrawRectangle(myPen,r);
            g.FillRectangle(brush, r);
            g.DrawEllipse(myPen, 0, 0, 200, 100);
            g.FillEllipse(brush1, r);


            
        }
    }
}
