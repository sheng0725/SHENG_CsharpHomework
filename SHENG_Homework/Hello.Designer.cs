namespace SHENG_Homework
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.btnSHello = new System.Windows.Forms.Button();
            this.btnSHi = new System.Windows.Forms.Button();
            this.labname = new System.Windows.Forms.Label();
            this.labENname = new System.Windows.Forms.Label();
            this.labsex = new System.Windows.Forms.Label();
            this.labcon = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtenname = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSHello
            // 
            this.btnSHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSHello.Location = new System.Drawing.Point(119, 293);
            this.btnSHello.Name = "btnSHello";
            this.btnSHello.Size = new System.Drawing.Size(130, 49);
            this.btnSHello.TabIndex = 0;
            this.btnSHello.Text = "Say HELLO !";
            this.btnSHello.UseVisualStyleBackColor = true;
            this.btnSHello.Click += new System.EventHandler(this.btnSHello_Click);
            // 
            // btnSHi
            // 
            this.btnSHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSHi.Location = new System.Drawing.Point(266, 293);
            this.btnSHi.Name = "btnSHi";
            this.btnSHi.Size = new System.Drawing.Size(130, 49);
            this.btnSHi.TabIndex = 1;
            this.btnSHi.Text = "Say HI !";
            this.btnSHi.UseVisualStyleBackColor = true;
            this.btnSHi.Click += new System.EventHandler(this.btnSHi_Click);
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(118, 50);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(58, 21);
            this.labname.TabIndex = 2;
            this.labname.Text = "姓名：";
            // 
            // labENname
            // 
            this.labENname.AutoSize = true;
            this.labENname.BackColor = System.Drawing.Color.Transparent;
            this.labENname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labENname.Location = new System.Drawing.Point(118, 109);
            this.labENname.Name = "labENname";
            this.labENname.Size = new System.Drawing.Size(131, 21);
            this.labENname.TabIndex = 3;
            this.labENname.Text = "English Name：";
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.BackColor = System.Drawing.Color.Transparent;
            this.labsex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labsex.Location = new System.Drawing.Point(120, 174);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(58, 21);
            this.labsex.TabIndex = 4;
            this.labsex.Text = "性別：";
            // 
            // labcon
            // 
            this.labcon.AutoSize = true;
            this.labcon.BackColor = System.Drawing.Color.Transparent;
            this.labcon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcon.Location = new System.Drawing.Point(120, 229);
            this.labcon.Name = "labcon";
            this.labcon.Size = new System.Drawing.Size(58, 21);
            this.labcon.TabIndex = 5;
            this.labcon.Text = "星座：";
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtcname.Location = new System.Drawing.Point(244, 50);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(137, 29);
            this.txtcname.TabIndex = 6;
            // 
            // txtenname
            // 
            this.txtenname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtenname.Location = new System.Drawing.Point(244, 109);
            this.txtenname.Name = "txtenname";
            this.txtenname.Size = new System.Drawing.Size(137, 29);
            this.txtenname.TabIndex = 7;
            // 
            // txtsex
            // 
            this.txtsex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsex.Location = new System.Drawing.Point(244, 175);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(137, 29);
            this.txtsex.TabIndex = 8;
            // 
            // txtcon
            // 
            this.txtcon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtcon.Location = new System.Drawing.Point(244, 230);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(137, 29);
            this.txtcon.TabIndex = 9;
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtenname);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.labcon);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.labENname);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.btnSHi);
            this.Controls.Add(this.btnSHello);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSHello;
        private System.Windows.Forms.Button btnSHi;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labENname;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.Label labcon;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtenname;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtcon;
    }
}