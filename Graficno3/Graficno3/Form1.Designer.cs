namespace Graficno3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DBarva = new System.Windows.Forms.ColorDialog();
            this.BarvaB = new System.Windows.Forms.Button();
            this.FontB = new System.Windows.Forms.Button();
            this.DFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BarvaB
            // 
            this.BarvaB.Location = new System.Drawing.Point(125, 127);
            this.BarvaB.Name = "BarvaB";
            this.BarvaB.Size = new System.Drawing.Size(75, 23);
            this.BarvaB.TabIndex = 1;
            this.BarvaB.Text = "Barva";
            this.BarvaB.UseVisualStyleBackColor = true;
            this.BarvaB.Click += new System.EventHandler(this.BarvaB_Click);
            // 
            // FontB
            // 
            this.FontB.Location = new System.Drawing.Point(339, 131);
            this.FontB.Name = "FontB";
            this.FontB.Size = new System.Drawing.Size(75, 23);
            this.FontB.TabIndex = 2;
            this.FontB.Text = "Font";
            this.FontB.UseVisualStyleBackColor = true;
            this.FontB.Click += new System.EventHandler(this.FontB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 195);
            this.Controls.Add(this.FontB);
            this.Controls.Add(this.BarvaB);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog DBarva;
        private System.Windows.Forms.Button BarvaB;
        private System.Windows.Forms.Button FontB;
        private System.Windows.Forms.FontDialog DFont;
    }
}

