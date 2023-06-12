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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
            GenerateAnswer();
        }

        private GuessReturn GRForm;

        private int answer;

        public void GenerateAnswer()
        {
            // 使用 Random 類別來生成隨機數字
            Random random = new Random();
            answer = random.Next(1, 101); // 生成 1 到 100 之間的隨機數字
        }

        public void ResetGuessRange()
        {
            // 重置猜測範圍
            label1.Text = $"Please Select A Number Between 1 to 100!";
        }

        public void UpdateGuessResult(string result)
        {
            label1.Text = result;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (GRForm == null || GRForm.IsDisposed) // 檢查表單是否已經存在或已經被關閉
            {
                GRForm = new GuessReturn(answer);
                GRForm.Owner = this; // 設定 Owner 為 Guess 表單
                // 設定 ReturnGuess 表單的位置為螢幕中間
                GRForm.StartPosition = FormStartPosition.CenterScreen;

                GRForm.Show();
            }
            else
            {
                GRForm.BringToFront(); // 如果表單已經存在，將其帶到前台
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Answer:{answer}", "", MessageBoxButtons.OK);
            GenerateAnswer();
            ResetGuessRange();
        }
    }
}
