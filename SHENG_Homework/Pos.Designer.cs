namespace SHENG_Homework
{
    partial class Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pos));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncookie = new System.Windows.Forms.Button();
            this.btnbread = new System.Windows.Forms.Button();
            this.btncake = new System.Windows.Forms.Button();
            this.btncoffee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncard = new System.Windows.Forms.Button();
            this.btncash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labList = new System.Windows.Forms.Label();
            this.btnListclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜單 Menu";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btncookie);
            this.panel1.Controls.Add(this.btnbread);
            this.panel1.Controls.Add(this.btncake);
            this.panel1.Controls.Add(this.btncoffee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(16, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 300);
            this.panel1.TabIndex = 2;
            // 
            // btncookie
            // 
            this.btncookie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncookie.BackgroundImage")));
            this.btncookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncookie.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncookie.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btncookie.Location = new System.Drawing.Point(125, 170);
            this.btncookie.Name = "btncookie";
            this.btncookie.Size = new System.Drawing.Size(80, 100);
            this.btncookie.TabIndex = 4;
            this.btncookie.Text = "餅乾\r\n$80";
            this.btncookie.UseVisualStyleBackColor = true;
            this.btncookie.Click += new System.EventHandler(this.btncookie_Click);
            // 
            // btnbread
            // 
            this.btnbread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbread.BackgroundImage")));
            this.btnbread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbread.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbread.Location = new System.Drawing.Point(23, 170);
            this.btnbread.Name = "btnbread";
            this.btnbread.Size = new System.Drawing.Size(80, 100);
            this.btnbread.TabIndex = 3;
            this.btnbread.Text = "麵包\r\n$150";
            this.btnbread.UseVisualStyleBackColor = true;
            this.btnbread.Click += new System.EventHandler(this.btnbread_Click);
            // 
            // btncake
            // 
            this.btncake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncake.BackgroundImage")));
            this.btncake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncake.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncake.Location = new System.Drawing.Point(125, 51);
            this.btncake.Name = "btncake";
            this.btncake.Size = new System.Drawing.Size(80, 100);
            this.btncake.TabIndex = 2;
            this.btncake.Text = "蛋糕\r\n$200";
            this.btncake.UseVisualStyleBackColor = true;
            this.btncake.Click += new System.EventHandler(this.btncake_Click);
            // 
            // btncoffee
            // 
            this.btncoffee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoffee.BackgroundImage")));
            this.btncoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncoffee.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncoffee.Location = new System.Drawing.Point(23, 51);
            this.btncoffee.Name = "btncoffee";
            this.btncoffee.Size = new System.Drawing.Size(80, 100);
            this.btncoffee.TabIndex = 1;
            this.btncoffee.Text = "咖啡\r\n$100\r\n";
            this.btncoffee.UseVisualStyleBackColor = true;
            this.btncoffee.Click += new System.EventHandler(this.btncoffee_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labtotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(252, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 3;
            // 
            // labtotal
            // 
            this.labtotal.BackColor = System.Drawing.Color.Black;
            this.labtotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtotal.ForeColor = System.Drawing.Color.White;
            this.labtotal.Location = new System.Drawing.Point(15, 39);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(218, 40);
            this.labtotal.TabIndex = 6;
            this.labtotal.Text = "NT$ 0";
            this.labtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "總金額 Total Price";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btncard);
            this.panel3.Controls.Add(this.btncash);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel3.Location = new System.Drawing.Point(252, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 100);
            this.panel3.TabIndex = 4;
            // 
            // btncard
            // 
            this.btncard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncard.Location = new System.Drawing.Point(136, 30);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(100, 40);
            this.btncard.TabIndex = 4;
            this.btncard.Text = "信用卡";
            this.btncard.UseVisualStyleBackColor = true;
            this.btncard.Click += new System.EventHandler(this.btncard_Click);
            // 
            // btncash
            // 
            this.btncash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncash.Location = new System.Drawing.Point(19, 30);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(100, 40);
            this.btncash.TabIndex = 3;
            this.btncash.Text = "現金";
            this.btncash.UseVisualStyleBackColor = true;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label4.Location = new System.Drawing.Point(-1, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "付款方式";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labList);
            this.panel4.Controls.Add(this.btnListclear);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel4.Location = new System.Drawing.Point(508, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 300);
            this.panel4.TabIndex = 5;
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.White;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(14, 34);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(254, 218);
            this.labList.TabIndex = 6;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnListclear
            // 
            this.btnListclear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListclear.Location = new System.Drawing.Point(175, 255);
            this.btnListclear.Name = "btnListclear";
            this.btnListclear.Size = new System.Drawing.Size(100, 40);
            this.btnListclear.TabIndex = 5;
            this.btnListclear.Text = "清除清單";
            this.btnListclear.UseVisualStyleBackColor = true;
            this.btnListclear.Click += new System.EventHandler(this.btnListclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "購物清單 List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(399, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "信用卡享9折!";
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Pos";
            this.Text = "Pos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btncookie;
        private System.Windows.Forms.Button btnbread;
        private System.Windows.Forms.Button btncake;
        private System.Windows.Forms.Button btncoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncard;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListclear;
        private System.Windows.Forms.Label labtotal;
        private System.Windows.Forms.Label labList;
    }
}