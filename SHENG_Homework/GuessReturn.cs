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
    public partial class GuessReturn : Form
    {
        int answer, max = 100, min = 0;
        public GuessReturn(int answer)
        {
            InitializeComponent();
            this.answer = answer;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumReturn.Text, out int num))
            {
                // 輸入為數字的情況
                if (num >= 0 && num <= 100)
                {
                    int guess = int.Parse(txtNumReturn.Text);
                    if (guess >= min && guess < max)
                    {
                        if (guess > answer)
                        {
                            max = guess;

                            Guess guessForm = (Guess)this.Owner;
                            guessForm.UpdateGuessResult($"Too Large!!!\r\nBetween {min} and {max}");
                        }
                        else if (guess < answer)
                        {
                            min = guess;

                            Guess guessForm = (Guess)this.Owner;
                            guessForm.UpdateGuessResult($"Too Small!!! \r\nBetween{min}and{max}");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show($"Congradulations!!!You got {answer}!!!",
                                                  "", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"請輸入{min}~{max}之間的數字。", "錯誤",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("請輸入0~100之間的數字。", "錯誤",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Stop);
                }
            }
            else
            {
                // 輸入不是數字的情況
                DialogResult result = MessageBox.Show("請輸入數字。", "錯誤",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Stop);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Guess guessForm = (Guess)this.Owner;
            guessForm.GenerateAnswer();
            guessForm.ResetGuessRange();
            Close();
        }
    }
}
