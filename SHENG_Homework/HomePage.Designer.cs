using System.Windows.Forms;

namespace SHENG_Homework
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnloan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.butPos = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPictureViewer = new System.Windows.Forms.Button();
            this.btn小畫家 = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.btnOXGame = new System.Windows.Forms.Button();
            this.btnForDoWhile = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnStudentGrade = new System.Windows.Forms.Button();
            this.btnStudentStructForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnloan
            // 
            this.btnloan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnloan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnloan.Location = new System.Drawing.Point(9, 39);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(152, 30);
            this.btnloan.TabIndex = 1;
            this.btnloan.Text = "Loan";
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(9, 3);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(152, 30);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // butPos
            // 
            this.butPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPos.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butPos.Location = new System.Drawing.Point(9, 75);
            this.butPos.Name = "butPos";
            this.butPos.Size = new System.Drawing.Size(152, 30);
            this.butPos.TabIndex = 2;
            this.butPos.Text = "POS";
            this.butPos.UseVisualStyleBackColor = true;
            this.butPos.Click += new System.EventHandler(this.butPos_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnPictureViewer);
            this.splitContainer2.Panel1.Controls.Add(this.btn小畫家);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotepad);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.btnOXGame);
            this.splitContainer2.Panel1.Controls.Add(this.btnForDoWhile);
            this.splitContainer2.Panel1.Controls.Add(this.btnCalculator);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGrade);
            this.splitContainer2.Panel1.Controls.Add(this.butPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnloan);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentStructForm);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(798, 370);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlarm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlarm.Location = new System.Drawing.Point(9, 471);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(152, 30);
            this.btnAlarm.TabIndex = 14;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuess.Location = new System.Drawing.Point(9, 435);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(152, 30);
            this.btnGuess.TabIndex = 13;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnPictureViewer
            // 
            this.btnPictureViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPictureViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPictureViewer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnPictureViewer.Location = new System.Drawing.Point(9, 399);
            this.btnPictureViewer.Name = "btnPictureViewer";
            this.btnPictureViewer.Size = new System.Drawing.Size(152, 30);
            this.btnPictureViewer.TabIndex = 12;
            this.btnPictureViewer.Text = "Picture Viewer";
            this.btnPictureViewer.UseVisualStyleBackColor = true;
            this.btnPictureViewer.Click += new System.EventHandler(this.btnPictureViewer_Click);
            // 
            // btn小畫家
            // 
            this.btn小畫家.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn小畫家.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn小畫家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn小畫家.Location = new System.Drawing.Point(9, 363);
            this.btn小畫家.Name = "btn小畫家";
            this.btn小畫家.Size = new System.Drawing.Size(152, 30);
            this.btn小畫家.TabIndex = 11;
            this.btn小畫家.Text = "小畫家";
            this.btn小畫家.UseVisualStyleBackColor = true;
            this.btn小畫家.Click += new System.EventHandler(this.btn小畫家_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNotepad.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnNotepad.Location = new System.Drawing.Point(9, 327);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(152, 30);
            this.btnNotepad.TabIndex = 10;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenSaver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScreenSaver.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnScreenSaver.Location = new System.Drawing.Point(9, 291);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(152, 30);
            this.btnScreenSaver.TabIndex = 9;
            this.btnScreenSaver.Text = "螢幕保護";
            this.btnScreenSaver.UseVisualStyleBackColor = true;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // btnOXGame
            // 
            this.btnOXGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOXGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOXGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnOXGame.Location = new System.Drawing.Point(9, 255);
            this.btnOXGame.Name = "btnOXGame";
            this.btnOXGame.Size = new System.Drawing.Size(152, 30);
            this.btnOXGame.TabIndex = 8;
            this.btnOXGame.Text = "井字遊戲";
            this.btnOXGame.UseVisualStyleBackColor = true;
            this.btnOXGame.Click += new System.EventHandler(this.btnOXGame_Click);
            // 
            // btnForDoWhile
            // 
            this.btnForDoWhile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForDoWhile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnForDoWhile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnForDoWhile.Location = new System.Drawing.Point(9, 219);
            this.btnForDoWhile.Name = "btnForDoWhile";
            this.btnForDoWhile.Size = new System.Drawing.Size(152, 30);
            this.btnForDoWhile.TabIndex = 7;
            this.btnForDoWhile.Text = "ForDoWhile";
            this.btnForDoWhile.UseVisualStyleBackColor = true;
            this.btnForDoWhile.Click += new System.EventHandler(this.btnForDoWhile_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculator.Location = new System.Drawing.Point(9, 183);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(152, 30);
            this.btnCalculator.TabIndex = 6;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnStudentGrade
            // 
            this.btnStudentGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStudentGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudentGrade.Location = new System.Drawing.Point(9, 147);
            this.btnStudentGrade.Name = "btnStudentGrade";
            this.btnStudentGrade.Size = new System.Drawing.Size(152, 30);
            this.btnStudentGrade.TabIndex = 4;
            this.btnStudentGrade.Text = "StudentGrade";
            this.btnStudentGrade.UseVisualStyleBackColor = true;
            this.btnStudentGrade.Click += new System.EventHandler(this.btnStudentGrade_Click);
            // 
            // btnStudentStructForm
            // 
            this.btnStudentStructForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentStructForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStudentStructForm.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudentStructForm.Location = new System.Drawing.Point(9, 111);
            this.btnStudentStructForm.Name = "btnStudentStructForm";
            this.btnStudentStructForm.Size = new System.Drawing.Size(152, 30);
            this.btnStudentStructForm.TabIndex = 3;
            this.btnStudentStructForm.Text = "Student_StructForm";
            this.btnStudentStructForm.UseVisualStyleBackColor = true;
            this.btnStudentStructForm.Click += new System.EventHandler(this.btnStudentStructForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnloan;
        private Button btnHello;
        private Button butPos;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button btnStudentStructForm;
        private Button btnStudentGrade;
        private Button btnCalculator;
        private Button btnOXGame;
        private Button btnForDoWhile;
        private Button btnNotepad;
        private Button btnScreenSaver;
        private Button btnAlarm;
        private Button btnGuess;
        private Button btnPictureViewer;
        private Button btn小畫家;
        private PictureBox pictureBox1;
    }
}