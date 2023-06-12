using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SHENG_Homework
{
    public partial class Calculator : Form
    {
        double Num1,Num2,Answer;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out Num1)
                                    && double.TryParse(txtNum2.Text, out Num2);
            if (isNum1)
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                Answer = Num1 + Num2;
                labAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("親 您目前使用的是計算機");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out Num1)
                                   && double.TryParse(txtNum2.Text, out Num2);
            if (isNum1)
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                Answer = Num1 - Num2;
                labAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("親 您目前使用的是計算機");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out Num1)
                                    && double.TryParse(txtNum2.Text, out Num2);
            if (isNum1)
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                Answer = Num1 * Num2;
                labAnswer.Text = Answer.ToString();
            }
            else
            {
                MessageBox.Show("親 您目前使用的是計算機");
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out Num1)
                                    && double.TryParse(txtNum2.Text, out Num2);
            if (isNum1)
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);
                Answer = Num1 / Num2;
                labAnswer.Text = Answer.ToString("F4");
            }
            else
            {
                MessageBox.Show("親 您目前使用的是計算機");
            }
        }
    }
}
