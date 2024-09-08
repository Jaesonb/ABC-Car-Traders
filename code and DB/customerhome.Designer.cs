namespace ABC_Car_Traders
{
    partial class customerhome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.uc_customercar1 = new ABC_Car_Traders.uc_customercar();
            this.uc_customercarparts1 = new ABC_Car_Traders.uc_customercarparts();
            this.uc_customerorderstatus1 = new ABC_Car_Traders.uc_customerorderstatus();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 365);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 61);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2, 249);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 61);
            this.button7.TabIndex = 5;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(2, 165);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 61);
            this.button9.TabIndex = 3;
            this.button9.Text = "Order";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(2, 83);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(134, 61);
            this.button11.TabIndex = 1;
            this.button11.Text = "Car Parts";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(2, 2);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(134, 61);
            this.button12.TabIndex = 0;
            this.button12.Text = "Car";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // uc_customercar1
            // 
            this.uc_customercar1.Location = new System.Drawing.Point(142, 2);
            this.uc_customercar1.Name = "uc_customercar1";
            this.uc_customercar1.Size = new System.Drawing.Size(455, 365);
            this.uc_customercar1.TabIndex = 15;
            // 
            // uc_customercarparts1
            // 
            this.uc_customercarparts1.Location = new System.Drawing.Point(142, 2);
            this.uc_customercarparts1.Name = "uc_customercarparts1";
            this.uc_customercarparts1.Size = new System.Drawing.Size(455, 365);
            this.uc_customercarparts1.TabIndex = 16;
            // 
            // uc_customerorderstatus1
            // 
            this.uc_customerorderstatus1.Location = new System.Drawing.Point(142, 2);
            this.uc_customerorderstatus1.Name = "uc_customerorderstatus1";
            this.uc_customerorderstatus1.Size = new System.Drawing.Size(455, 365);
            this.uc_customerorderstatus1.TabIndex = 17;
            // 
            // customerhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uc_customerorderstatus1);
            this.Controls.Add(this.uc_customercarparts1);
            this.Controls.Add(this.uc_customercar1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "customerhome";
            this.Text = "customerhome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private uc_customercar uc_customercar1;
        private uc_customercarparts uc_customercarparts1;
        private uc_customerorderstatus uc_customerorderstatus1;
    }
}