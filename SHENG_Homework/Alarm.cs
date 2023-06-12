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
    public partial class Alarm : Form
    {
        private DateTime alarmTime;

        public Alarm()
        {
            InitializeComponent();
            labNowTime.Text = DateTime.Now.ToString(" HH:mm:ss ");
            timer = new Timer();
            timer.Interval = 1000; // 每秒檢查一次時間
            timer.Tick += Timer_Tick;
        }

        private void timerNowtime_Tick(object sender, EventArgs e)
        {
            labNowTime.Text = DateTime.Now.ToString(" HH:mm:ss ");
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtSetTime.Text, out alarmTime))
            {
                // 啟動 Timer
                timer.Start();
            }
            else
            {
                MessageBox.Show($"無效的時間格式！\r請輸入HH:mm:ss格式 \r例如: 20:50:59","錯誤",MessageBoxButtons.OK);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 計算剩餘時間
            TimeSpan remainingTime = alarmTime - DateTime.Now;

            // 更新顯示剩餘時間的標籤(Label)
            if (remainingTime.TotalSeconds > 0)
            {
                labRemaining.Text = string.Format("{0}:{1}:{2}",
                    remainingTime.Hours.ToString("00"),
                    remainingTime.Minutes.ToString("00"),
                    remainingTime.Seconds.ToString("00"));
            }
            else
            {
                labRemaining.Text = "時間到！";
                timer.Stop();
                MessageBox.Show("時間到！", "鬧鐘", MessageBoxButtons.OK);
            }
        }
    }
}
