namespace SHENG_Homework
{
    partial class Student_StructForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnStoreShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labmaxmin = new System.Windows.Forms.Label();
            this.labscore = new System.Windows.Forms.Label();
            this.butmaxmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(108, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(108, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(108, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(108, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(187, 49);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 38);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCN
            // 
            this.txtCN.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCN.Location = new System.Drawing.Point(187, 115);
            this.txtCN.Multiline = true;
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(126, 38);
            this.txtCN.TabIndex = 5;
            this.txtCN.Text = "0";
            this.txtCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEN
            // 
            this.txtEN.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEN.Location = new System.Drawing.Point(187, 184);
            this.txtEN.Multiline = true;
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(126, 38);
            this.txtEN.TabIndex = 6;
            this.txtEN.Text = "0";
            this.txtEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(187, 260);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(126, 38);
            this.txtMath.TabIndex = 7;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(93, 333);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(120, 43);
            this.btnStore.TabIndex = 8;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnStoreShow
            // 
            this.btnStoreShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStoreShow.Location = new System.Drawing.Point(249, 333);
            this.btnStoreShow.Name = "btnStoreShow";
            this.btnStoreShow.Size = new System.Drawing.Size(120, 43);
            this.btnStoreShow.TabIndex = 9;
            this.btnStoreShow.Text = "顯示儲存內容";
            this.btnStoreShow.UseVisualStyleBackColor = true;
            this.btnStoreShow.Click += new System.EventHandler(this.btnStoreShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labmaxmin);
            this.groupBox1.Controls.Add(this.labscore);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(409, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 352);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labmaxmin
            // 
            this.labmaxmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmaxmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmaxmin.Location = new System.Drawing.Point(6, 238);
            this.labmaxmin.Name = "labmaxmin";
            this.labmaxmin.Size = new System.Drawing.Size(334, 111);
            this.labmaxmin.TabIndex = 13;
            // 
            // labscore
            // 
            this.labscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labscore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labscore.Location = new System.Drawing.Point(6, 35);
            this.labscore.Name = "labscore";
            this.labscore.Size = new System.Drawing.Size(334, 199);
            this.labscore.TabIndex = 12;
            // 
            // butmaxmin
            // 
            this.butmaxmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butmaxmin.Location = new System.Drawing.Point(553, 389);
            this.butmaxmin.Name = "butmaxmin";
            this.butmaxmin.Size = new System.Drawing.Size(185, 43);
            this.butmaxmin.TabIndex = 11;
            this.butmaxmin.Text = "最高分/最低分科目";
            this.butmaxmin.UseVisualStyleBackColor = true;
            this.butmaxmin.Click += new System.EventHandler(this.butmaxmin_Click);
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butmaxmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStoreShow);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnStoreShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butmaxmin;
        private System.Windows.Forms.Label labscore;
        private System.Windows.Forms.Label labmaxmin;
    }
}