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
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }

        public bool IsNum(string strNum, out int numOddEven)
        {
            bool isNum = int.TryParse(strNum, out numOddEven);
            return isNum;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            int num;
            bool isNum = IsNum(txtNumber.Text, out num);
            if (isNum)
            {
                if ((Math.Abs(num)) % 2 == 0)
                {
                    labResult.Text = $"輸入的數 {num} 為偶數。";
                }
                else
                {
                    labResult.Text = $"輸入的數 {num} 為奇數。";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool NumberReturnOK = true;

            if (IsNum(txtFrom.Text, out numFrom) && IsNum(txtTo.Text, out numTo) && IsNum(txtStep.Text, out numStep))
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (NumberReturnOK)
                {
                    int total = 0;
                    for (int i = numFrom; i <= numTo; i += numStep)
                    {
                        total += i;
                    }
                    labResult.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool NumberReturnOK = true;

            if (IsNum(txtFrom.Text, out numFrom) && IsNum(txtTo.Text, out numTo) && IsNum(txtStep.Text, out numStep))
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (NumberReturnOK)
                {
                    int total = 0;
                    int i = numFrom;
                    while (i <= numTo)
                    {
                        total += i;
                        i += numStep;
                    }
                    labResult.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int numFrom, numTo, numStep;
            bool NumberReturnOK = true;

            if (IsNum(txtFrom.Text, out numFrom) && IsNum(txtTo.Text, out numTo) && IsNum(txtStep.Text, out numStep))
            {
                if (numFrom > numTo)
                {
                    MessageBox.Show("From數字需要大於To", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (numStep < 1)
                {
                    MessageBox.Show("Stpe數字需要大於0", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumberReturnOK = false;
                }
                if (NumberReturnOK)
                {
                    int total = 0;
                    int i = numFrom;
                    do
                    {
                        total += i;
                        i += numStep;
                    } while (i <= numTo);
                    labResult.Text = $"{numFrom} 到 {numTo} 相隔 {numStep}\n加總為 {total}";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            string result = "";
            int rows;
            if (int.TryParse(txtRows.Text, out rows))
            {
                if (rows < 0)
                {
                    MessageBox.Show("請輸入數值", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            result += "*";
                        }
                        result += "\n";
                    }
                    labResult.Text = result;
                }
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnIntOddEven_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int countOdd = 0;
            int countEven = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            result = $"int陣列arr0711[ {string.Join(" , ", arr0711)} ]\n奇數共 {countOdd}\n偶數共 {countEven}";
            labResult.Text = result;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            string result = "";
            int maxNum = 0;
            int minNum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (i == 0)
                {
                    maxNum = arr0711[i];
                    minNum = arr0711[i];
                }
                if (maxNum < arr0711[i])
                {
                    maxNum = arr0711[i];
                }
                if (minNum > arr0711[i])
                {
                    minNum = arr0711[i];
                }
            }
            result = $"int陣列arr0711[ {string.Join(" , ", arr0711)} ]\n最大值為{maxNum}\n最小值為{minNum}";
            labResult.Text = result;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            string result = "";
            int total = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                total += arr0711[i];
            }
            result = $"int陣列arr0711[ {string.Join(" , ", arr0711)} ]\n加總為 {total}";
            labResult.Text = result;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string result = "";
            int maxNum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (i == 0)
                {
                    maxNum = arr0711[i];
                }
                if (maxNum < arr0711[i])
                {
                    maxNum = arr0711[i];
                }
            }
            result = $"int陣列arr0711[ {string.Join(" , ", arr0711)} ]\n最大值為{maxNum}";
            labResult.Text = result;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int minNum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (i == 0)
                {
                    minNum = arr0711[i];
                }
                if (minNum > arr0711[i])
                {
                    minNum = arr0711[i];
                }
            }
            result = $"int陣列arr0711[ {string.Join(" , ", arr0711)} ]\n最小值為{minNum}";
            labResult.Text = result;
        }

        string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        private void btnLongStr_Click(object sender, EventArgs e)
        {
            string result = "";
            int strLength = 0;
            int indexOfMaxLength = 0;
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                if (i == 0)
                {
                    strLength = arr0711_Str[i].Length;
                }
                else
                {
                    if (strLength < arr0711_Str[i].Length)
                    {
                        strLength = arr0711_Str[i].Length;
                        indexOfMaxLength = i;
                    }
                }
            }
            result = $"int陣列arr0711_Str: {string.Join(" , ", arr0711_Str)} \n最長的名子為{arr0711_Str[indexOfMaxLength]}";
            labResult.Text = result;
        }

        private void btnCCount_Click(object sender, EventArgs e)
        {
            string result = "";
            int count = 0;
            for (int i = 0; i < arr0711_Str.Length; i++)
            {
                if (arr0711_Str[i].IndexOf("c") >= 0 || arr0711_Str[i].IndexOf("C") >= 0)
                {
                    count++;
                }
            }
            result = $"int陣列arr0711_Str: {string.Join(" , ", arr0711_Str)} \n有C及c的名子共有{count}個";
            labResult.Text = result;
        }

        private void btnTwoArr10_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnTwoArr01_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        result += " 0 ";
                    }
                    else
                    {
                        result += " 1 ";
                    }
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnTwoArr1001_Click(object sender, EventArgs e)
        {
            string result = "";
            bool check0And1 = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (check0And1)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";
                    }
                    check0And1 = !check0And1;
                }
                check0And1 = !check0And1;
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btn100Binary_Click(object sender, EventArgs e)
        {
            string result = "";
            string reverseResult = "";
            int num100 = 100;
            while (num100 > 0)
            {
                if (num100 % 2 == 1)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                if (num100 == 1)
                {
                    break;
                }
                num100 /= 2;
            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reverseResult += result[i];
            }
            labResult.Text = reverseResult;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            string result = "樂透號碼\n";
            int[] LotteryNum = new int[6];
            int RandomNum;
            Random rand = new Random();
            int i = 0;
            while (i < 6)
            {
                RandomNum = rand.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    if (RandomNum == LotteryNum[j])
                    {
                        RandomNum = 0;
                    }
                }
                if (RandomNum != 0)
                {
                    LotteryNum[i] = RandomNum;
                    result += $"{LotteryNum[i]} ";
                    i++;
                }
            }
            labResult.Text = result;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string result = "";
            int n1 = 100;
            int n2 = 200;
            result = $"換位前n1={n1}, n2={n2}\n";
            (n1, n2) = (n2, n1);
            result += $"換位前n1={n1}, n2={n2}\n";
            labResult.Text = result;
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            string result = "九九乘法表\n";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if (i * j < 10)
                    {
                        result += $" {j}x {i}=  {j * i}|";
                    }
                    else
                    {
                        result += $" {j}x {i}= {j * i}|";
                    }
                }
                result += "\n";
            }
            labResult.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }
    }
}
