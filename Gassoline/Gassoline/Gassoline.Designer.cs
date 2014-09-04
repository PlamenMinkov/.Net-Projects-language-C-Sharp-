namespace Gassoline
{
    partial class Gassoline
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
            this.km = new System.Windows.Forms.Label();
            this.gallon = new System.Windows.Forms.Label();
            this.lit = new System.Windows.Forms.TextBox();
            this.mile = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Location = new System.Drawing.Point(114, 42);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(46, 13);
            this.km.TabIndex = 0;
            this.km.Text = "l/100km";
            // 
            // gallon
            // 
            this.gallon.AutoSize = true;
            this.gallon.Location = new System.Drawing.Point(277, 43);
            this.gallon.Name = "gallon";
            this.gallon.Size = new System.Drawing.Size(58, 13);
            this.gallon.TabIndex = 1;
            this.gallon.Text = "mile/gallon";
            // 
            // lit
            // 
            this.lit.Location = new System.Drawing.Point(12, 36);
            this.lit.Name = "lit";
            this.lit.Size = new System.Drawing.Size(100, 20);
            this.lit.TabIndex = 2;
            // 
            // mile
            // 
            this.mile.Location = new System.Drawing.Point(172, 36);
            this.mile.Name = "mile";
            this.mile.Size = new System.Drawing.Size(100, 20);
            this.mile.TabIndex = 3;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(25, 71);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 4;
            this.b1.Text = "Calculate";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(184, 71);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 5;
            this.b2.Text = "Calculate";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 120);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.mile);
            this.Controls.Add(this.lit);
            this.Controls.Add(this.gallon);
            this.Controls.Add(this.km);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Label gallon;
        private System.Windows.Forms.TextBox lit;
        private System.Windows.Forms.TextBox mile;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
    }
}

