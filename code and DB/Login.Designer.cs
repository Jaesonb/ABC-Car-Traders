namespace ABC_Car_Traders
{
    partial class Login
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(221, 152);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Password";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(219, 87);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Username";
            this.lbl1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(320, 267);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(99, 29);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Login";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(320, 87);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(329, 20);
            this.txtbox1.TabIndex = 4;
            this.txtbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(320, 149);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(329, 20);
            this.txtbox2.TabIndex = 5;
            this.txtbox2.UseSystemPasswordChar = true;
            this.txtbox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(436, 267);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(99, 29);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Register";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(320, 208);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(329, 20);
            this.txtbox3.TabIndex = 7;
            this.txtbox3.TextChanged += new System.EventHandler(this.txtbox3_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(221, 215);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(32, 13);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Email";
            this.lbl3.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 440);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(49, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ABC CAR Traders";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

