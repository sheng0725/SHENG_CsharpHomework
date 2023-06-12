using SHENG_Homework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SHENG_Homework
{
    public partial class Notepad : Form
    {

        //判斷文件為開啟檔案(電腦本身就有)還是新建檔案,true = 開啟,false = 新建
        bool b = false;
        //判斷文件是否被保存,true = 保存 , false = 未保存
        bool s = true;
        public Notepad()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("tt HH:mm:ss ");
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfile();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
            ////richtextbox寫法
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //    s = true;
            //}
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 剪下TToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void tsmiColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                ////richtextbox寫法
                //textBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                ////richtextbox寫法
                //textBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void tsmiToUpper_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void tsmiToLower_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void tsmiAuto_Click(object sender, EventArgs e)
        {
            if (tsmiAuto.Checked == false)
            {
                tsmiAuto.Checked = true;
                textBox1.WordWrap = true;
            }
            else
            {
                tsmiAuto.Checked = false;
                textBox1.WordWrap = false;
            }
        }

        private void tsmiRed_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void tsmiGreen_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void tsmuBlue_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void tsmiBlack_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutform();
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            newfile();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            savefile();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            aboutform();
        }

        public void newfile()
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
            /*===RichTextBox寫法================================================================*/
            ////判斷目前開啟的檔案是否從電腦開啟,或者新建時檔案不為空,並且檔案尚未儲存
            //if (b == true || textBox1.Text.Trim() != "")
            //{
            //    // 如果文件為保存
            //    if (s == false)
            //    {
            //        string result;
            //        result = MessageBox.Show("檔案尚未儲存,是否儲存?", "儲存檔案", MessageBoxButtons.YesNoCancel).ToString();
            //        switch (result)
            //        {
            //            case "Yes":
            //                //如果文件是從電腦打開的
            //                if (b == true)
            //                {
            //                    //按照打開的路徑保存文件
            //                    textBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //                }
            //                //如果文件不是從電腦打開的
            //                else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //                {
            //                    textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //                }
            //                s = true;
            //                textBox1.Text = "";
            //                break;
            //            case "No":
            //                b = false;
            //                textBox1.Text = "";
            //                break;
            //            case "Cancel":
            //                break;
            //        }
            //    }
            //}
            //textBox1.Text = "";
        }

        public void openfile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
            /*=====RichTextBox寫法=====================================================*/
            //if (b == true || textBox1.Text.Trim() != "")
            //{
            //    if (s == false)
            //    {
            //        string result;
            //        result = MessageBox.Show("檔案尚未儲存,是否儲存?", "儲存檔案", MessageBoxButtons.YesNoCancel).ToString();

            //        switch (result)
            //        {
            //            case "Yes":
            //                if (b == true)
            //                {
            //                    textBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //                }
            //                else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //                {
            //                    textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //                }
            //                s = true;
            //                break;
            //            case "No":
            //                b = false;
            //                textBox1.Text = "";
            //                break;
            //        }
            //    }
            //}
            //openFileDialog1.RestoreDirectory = true;
            //if ((openFileDialog1.ShowDialog() == DialogResult.OK) && openFileDialog1.FileName != "")
            //{
            //    textBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //    b = true;
            //}
            //s = true;
        }

        public void savefile()
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
            /*======RichTextBox的寫法======================================================*/
            ////如果檔案從電腦打開並且修改了內容
            //if (b == true && textBox1.Modified == true)
            //{
            //    textBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //    s = true;
            //}
            //else if (b == false && textBox1.Text.Trim() != "" && saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    textBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            //    s = true;
            //    b = true;
            //    openFileDialog1.FileName = saveFileDialog1.FileName;
            //}
        }

        public void aboutform()
        {
            using (var dialog = new Form())
            {
                dialog.Text = "關於";
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.ControlBox = true;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.StartPosition = FormStartPosition.CenterScreen;
                dialog.Size = new Size(500, 500);
                dialog.ControlBox = true;

                var labeltitle = new Label();
                labeltitle.AutoSize = true;
                labeltitle.Text = "關於";
                labeltitle.Font = new Font("微軟正黑體", 26.25F/*, FontStyle.Bold, GraphicsUnit.Point, 136*/);
                labeltitle.Location = new Point(5, 5);
                labeltitle.TextAlign = ContentAlignment.TopLeft;
                dialog.Controls.Add(labeltitle);

                var label = new Label();
                label.AutoSize = true;
                label.Text = "關於什麼我也不知道";
                label.Font = new Font("微軟正黑體", 12F/*, FontStyle.Bold, GraphicsUnit.Point, 136*/);
                label.Location = new Point(labeltitle.Right + 100, 18);
                label.TextAlign = ContentAlignment.TopLeft;
                dialog.Controls.Add(label);

                // 新增PictureBox控制項
                var pictureBox = new PictureBox();
                pictureBox.Image = Resources.窩不知道; // 替換為你的圖片路徑
                pictureBox.BackColor = Color.White;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(10, labeltitle.Bottom + 10); // 設定圖片位置
                pictureBox.Size = new Size(dialog.Width - 30, dialog.Height - labeltitle.Bottom - 60); // 調整圖片大小以符合對話框
                dialog.Controls.Add(pictureBox);

                dialog.ShowDialog();
            }
        }
    }
}
