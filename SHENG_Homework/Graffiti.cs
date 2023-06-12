using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHENG_Homework
{
    public partial class Graffiti : Form
    {
        int x0,y0;
        Bitmap bmp;
        int penPoint;
        Color penColor;
        Graphics g;
        Pen pen;
        public Graffiti()
        {
            InitializeComponent();
            pen = new Pen(penColor, penPoint);
            bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Size = new Size(this.Width, this.Height);
            pictureBox1.Location = new Point(0, 0);
            penColor = Color.Black;
            penPoint = 1;
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            penColor = colorDialog.Color;
            labColor.BackColor = penColor;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(penColor, penPoint);
                g = Graphics.FromImage(bmp);
                g.DrawLine(pen, x0, y0, e.X, e.Y);
                pictureBox1.Image = bmp;
                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penPoint = trackBar1.Value;
            labFont.Text = trackBar1.Value.ToString();
        }
    }
}
