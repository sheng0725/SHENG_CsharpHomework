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
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private int imageSpeedX = 15;  // 圖片在水平方向上的移動速度
        private int imageSpeedY = 15;  // 圖片在垂直方向上的移動速度
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新圖片位置
            pictureBox1.Left += imageSpeedX;
            pictureBox1.Top += imageSpeedY;

            // 邊緣碰撞檢測
            if (pictureBox1.Left <= 0 || pictureBox1.Right >= ClientSize.Width)
            {
                imageSpeedX = -imageSpeedX;  // 水平方向速度取反，實現回彈效果
            }

            if (pictureBox1.Top <= 0 || pictureBox1.Bottom >= ClientSize.Height)
            {
                imageSpeedY = -imageSpeedY;  // 垂直方向速度取反，實現回彈效果
            }
        }

        private Point initialPosition;
        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            // 計算滑鼠移動的距離
            int distance = Math.Abs(Cursor.Position.X - initialPosition.X) + Math.Abs(Cursor.Position.Y - initialPosition.Y);
            // 如果距離超過指定閾值，則關閉視窗
            if (distance >= 950)
            {
                Close();
            }
        }

        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
