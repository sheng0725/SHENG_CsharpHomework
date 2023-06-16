namespace SHENG_Homework
{
    partial class StudentGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGrade));
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnResetdata = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.labViewAll = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labViewData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtMath.Location = new System.Drawing.Point(76, 141);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(88, 32);
            this.txtMath.TabIndex = 15;
            this.txtMath.Text = "100";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtEN.Location = new System.Drawing.Point(76, 96);
            this.txtEN.Multiline = true;
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(88, 32);
            this.txtEN.TabIndex = 14;
            this.txtEN.Text = "100";
            this.txtEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtCN.Location = new System.Drawing.Point(76, 51);
            this.txtCN.Multiline = true;
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(88, 32);
            this.txtCN.TabIndex = 13;
            this.txtCN.Text = "100";
            this.txtCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtName.Location = new System.Drawing.Point(76, 7);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 32);
            this.txtName.TabIndex = 12;
            this.txtName.Text = "1";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "數學：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "英文：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "國文：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名：";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudent.Location = new System.Drawing.Point(25, 179);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(128, 33);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom.Location = new System.Drawing.Point(25, 218);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(128, 33);
            this.btnRandom.TabIndex = 17;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(25, 257);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(128, 33);
            this.btnStatistics.TabIndex = 18;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnResetdata
            // 
            this.btnResetdata.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResetdata.Location = new System.Drawing.Point(25, 366);
            this.btnResetdata.Name = "btnResetdata";
            this.btnResetdata.Size = new System.Drawing.Size(128, 33);
            this.btnResetdata.TabIndex = 19;
            this.btnResetdata.Text = "重設所有資料";
            this.btnResetdata.UseVisualStyleBackColor = true;
            this.btnResetdata.Click += new System.EventHandler(this.btnResetdata_Click);
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(25, 405);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(128, 33);
            this.btnRandom20.TabIndex = 20;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // labViewAll
            // 
            this.labViewAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labViewAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.labViewAll.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labViewAll.Location = new System.Drawing.Point(181, 325);
            this.labViewAll.Name = "labViewAll";
            this.labViewAll.Size = new System.Drawing.Size(607, 113);
            this.labViewAll.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labViewData);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(181, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 310);
            this.panel1.TabIndex = 23;
            // 
            // labViewData
            // 
            this.labViewData.AutoSize = true;
            this.labViewData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labViewData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labViewData.Location = new System.Drawing.Point(4, 20);
            this.labViewData.Name = "labViewData";
            this.labViewData.Size = new System.Drawing.Size(2, 18);
            this.labViewData.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F);
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名       國文     英文     數學     總分     平均     最低     最高";
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labViewAll);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnResetdata);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnResetdata;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.Label labViewAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labViewData;
    }
}