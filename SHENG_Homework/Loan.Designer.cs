namespace SHENG_Homework
{
    partial class Loan
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
            this.btnallpay = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtdownpay = new System.Windows.Forms.TextBox();
            this.btnpmt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnallpay
            // 
            this.btnallpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnallpay.Location = new System.Drawing.Point(326, 276);
            this.btnallpay.Name = "btnallpay";
            this.btnallpay.Size = new System.Drawing.Size(130, 54);
            this.btnallpay.TabIndex = 1;
            this.btnallpay.Text = "總付款";
            this.btnallpay.UseVisualStyleBackColor = true;
            this.btnallpay.Click += new System.EventHandler(this.btnallpay_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreport.Location = new System.Drawing.Point(493, 277);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(130, 54);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(151, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(151, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "貸款期數(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(151, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(151, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "頭期款";
            // 
            // txtmoney
            // 
            this.txtmoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmoney.Location = new System.Drawing.Point(316, 39);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(184, 29);
            this.txtmoney.TabIndex = 7;
            this.txtmoney.Text = "100000";
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtyear.Location = new System.Drawing.Point(316, 93);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(184, 29);
            this.txtyear.TabIndex = 8;
            this.txtyear.Text = "2";
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtrate.Location = new System.Drawing.Point(316, 147);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(184, 29);
            this.txtrate.TabIndex = 9;
            this.txtrate.Text = "10";
            // 
            // txtdownpay
            // 
            this.txtdownpay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtdownpay.Location = new System.Drawing.Point(316, 195);
            this.txtdownpay.Name = "txtdownpay";
            this.txtdownpay.Size = new System.Drawing.Size(184, 29);
            this.txtdownpay.TabIndex = 10;
            this.txtdownpay.Text = "0";
            // 
            // btnpmt
            // 
            this.btnpmt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpmt.Location = new System.Drawing.Point(157, 277);
            this.btnpmt.Name = "btnpmt";
            this.btnpmt.Size = new System.Drawing.Size(130, 54);
            this.btnpmt.TabIndex = 0;
            this.btnpmt.Text = "PMT(月付)";
            this.btnpmt.UseVisualStyleBackColor = true;
            this.btnpmt.Click += new System.EventHandler(this.btnpmt_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdownpay);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnallpay);
            this.Controls.Add(this.btnpmt);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnallpay;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtdownpay;
        private System.Windows.Forms.Button btnpmt;
    }
}