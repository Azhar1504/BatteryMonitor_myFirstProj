namespace BatteryMonitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.BatStat = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.PowSrc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BatteryStatus";
            // 
            // BatStat
            // 
            this.BatStat.AutoSize = true;
            this.BatStat.Location = new System.Drawing.Point(215, 118);
            this.BatStat.Name = "BatStat";
            this.BatStat.Size = new System.Drawing.Size(41, 13);
            this.BatStat.TabIndex = 1;
            this.BatStat.Text = "Default";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(90, 173);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(74, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Power Source";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PowSrc
            // 
            this.PowSrc.AutoSize = true;
            this.PowSrc.Location = new System.Drawing.Point(215, 173);
            this.PowSrc.Name = "PowSrc";
            this.PowSrc.Size = new System.Drawing.Size(41, 13);
            this.PowSrc.TabIndex = 3;
            this.PowSrc.Text = "Default";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PowSrc);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.BatStat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BatStat;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label PowSrc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

