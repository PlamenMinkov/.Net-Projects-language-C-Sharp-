namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.b1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.res1 = new System.Windows.Forms.TextBox();
            this.res2 = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.win = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(26, 23);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(44, 12);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(26, 23);
            this.bt2.TabIndex = 1;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(76, 12);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(26, 23);
            this.bt3.TabIndex = 2;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(12, 41);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(26, 23);
            this.bt4.TabIndex = 3;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(76, 41);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(26, 23);
            this.bt6.TabIndex = 4;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(44, 41);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(26, 23);
            this.bt5.TabIndex = 5;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(12, 70);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(26, 23);
            this.bt7.TabIndex = 6;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(76, 70);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(26, 23);
            this.bt9.TabIndex = 7;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(44, 70);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(26, 23);
            this.bt8.TabIndex = 8;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(9, 109);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(58, 13);
            this.first.TabIndex = 9;
            this.first.Text = "First Player";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(9, 132);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(76, 13);
            this.second.TabIndex = 10;
            this.second.Text = "Second Player";
            // 
            // res1
            // 
            this.res1.Location = new System.Drawing.Point(96, 106);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(100, 20);
            this.res1.TabIndex = 11;
            // 
            // res2
            // 
            this.res2.Location = new System.Drawing.Point(96, 129);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(100, 20);
            this.res2.TabIndex = 12;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(121, 70);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "New Game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(110, 41);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(0, 13);
            this.win.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 162);
            this.Controls.Add(this.win);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.TextBox res1;
        private System.Windows.Forms.TextBox res2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label win;
    }
}

