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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
        }

        public struct Student
        {
            public string Name;
            public int Chi;
            public int Eng;
            public int Math;
        }
        List<Student> Students = new List<Student>();

        private bool IsValidScore(int score)
        {
            return score >= 0 && score <= 100;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            {
                Student stu;
                stu.Name = txtName.Text.ToString();

                if (IsDataLimitReached())
                {
                    return;
                }

                if (int.TryParse(txtCN.Text, out int chi)
                    && int.TryParse(txtEN.Text, out int eng)
                    && int.TryParse(txtMath.Text, out int math))
                {
                    if (IsValidScore(chi) && IsValidScore(eng) && IsValidScore(math))
                    {
                        stu.Chi = chi;
                        stu.Eng = eng;
                        stu.Math = math;

                        AddStudentData(stu);

                        btnStatistics.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("請輸入有效的成績（0到100之間）");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的成績");
                }
            }
        }
        private void AddStudentData(Student stu)
        {
            Students.Add(stu);

            int totalscores = stu.Chi + stu.Eng + stu.Math;
            double avg = Math.Round(totalscores / 3.0, 1);

            string maxSubject = "";
            string minSubject = "";

            int maxScore = Math.Max(stu.Chi, Math.Max(stu.Eng, stu.Math));
            int minScore = Math.Min(stu.Chi, Math.Min(stu.Eng, stu.Math));

            if (maxScore == stu.Chi)
                maxSubject = "國文";
            else if (maxScore == stu.Eng)
                maxSubject = "英文";
            else if (maxScore == stu.Math)
                maxSubject = "數學";

            if (minScore == stu.Chi)
                minSubject = "國文";
            else if (minScore == stu.Eng)
                minSubject = "英文";
            else if (minScore == stu.Math)
                minSubject = "數學";

            labViewData.Text += string.Format("{0,-10}{1,4}{2,9}{3,9}{4,9}{5,9}{6,9}{7,8}\r\n",
                                   stu.Name, stu.Chi, stu.Eng,
                                   stu.Math, totalscores, avg,
                                   minSubject + minScore, maxSubject + maxScore);

        }

        int studentCount = 0;
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (IsDataLimitReached())
            {
                return;
            }

            Random random = new Random();

            Student stu;
            stu.Name = (studentCount + 1).ToString();
            stu.Chi = random.Next(0, 101); // 產生 0 到 100 之間的隨機數字
            stu.Eng = random.Next(0, 101);
            stu.Math = random.Next(0, 101);

            studentCount++;

            AddStudentData(stu);

            btnStatistics.Enabled = true;
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            int additionalDataCount = 20;
            if (IsDataLimitReached())
            {
                return;
            }

            int remainingCapacity = 100 - Students.Count;
            int newDataCount = Math.Min(additionalDataCount, remainingCapacity);

            Random random = new Random();

            for (int i = 0; i < newDataCount; i++)
            {
                Student stu;
                stu.Name = (studentCount + 1).ToString();
                stu.Chi = random.Next(0, 101);
                stu.Eng = random.Next(0, 101);
                stu.Math = random.Next(0, 101);

                studentCount++;

                AddStudentData(stu);

                btnStatistics.Enabled = true;
            }
        }

        private void btnResetdata_Click(object sender, EventArgs e)
        {
            Students.Clear();

            // 重置計數器
            studentCount = 0;

            btnStatistics.Enabled = false;

            // 清空顯示資料的 labdata 控制項
            labViewData.Text = string.Empty;
            labViewAll.Text = string.Empty;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (Students.Count == 0)
            {
                MessageBox.Show("目前沒有學生資料可供統計");
                return;
            }
            int totalChinese = 0;
            int totalEnglish = 0;
            int totalMath = 0;
            int maxChinese = int.MinValue;
            int maxEnglish = int.MinValue;
            int maxMath = int.MinValue;
            int minChinese = int.MaxValue;
            int minEnglish = int.MaxValue;
            int minMath = int.MaxValue;

            foreach (Student student in Students)
            {
                totalChinese += student.Chi;
                totalEnglish += student.Eng;
                totalMath += student.Math;

                maxChinese = Math.Max(maxChinese, student.Chi);
                maxEnglish = Math.Max(maxEnglish, student.Eng);
                maxMath = Math.Max(maxMath, student.Math);

                minChinese = Math.Min(minChinese, student.Chi);
                minEnglish = Math.Min(minEnglish, student.Eng);
                minMath = Math.Min(minMath, student.Math);
            }

            double avgChinese = Math.Round((double)totalChinese / Students.Count, 1);
            double avgEnglish = Math.Round((double)totalEnglish / Students.Count, 1);
            double avgMath = Math.Round((double)totalMath / Students.Count, 1);


            labViewAll.Text = string.Format("總分{0,11}{1,9}{2,9}\r\n" +
                                   "平均{3,11:F1}{4,9:F1}{5,9:F1}\r\n" +
                                   "最高分{6,9}{7,9}{8,9}\r\n" +
                                   "最低分{9,9}{10,9}{11,9}",
                                   totalChinese, totalEnglish, totalMath,
                                   avgChinese, avgEnglish, avgMath,
                                   maxChinese, maxEnglish, maxMath,
                                   minChinese, minEnglish, minMath);

        }
        private bool IsDataLimitReached()
        {
            if (Students.Count >= 100)
            {
                MessageBox.Show("記憶體空間已滿，請先刪除舊有資料。", "警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
