namespace Pretvorba
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
            this.Vnostxt = new System.Windows.Forms.TextBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.Izracunaj = new System.Windows.Forms.Button();
            this.Pocisti = new System.Windows.Forms.Button();
            this.Vnos = new System.Windows.Forms.Label();
            this.Sprem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBPB = new System.Windows.Forms.RadioButton();
            this.JPYB = new System.Windows.Forms.RadioButton();
            this.USDB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vnostxt
            // 
            this.Vnostxt.Location = new System.Drawing.Point(246, 39);
            this.Vnostxt.Name = "Vnostxt";
            this.Vnostxt.Size = new System.Drawing.Size(100, 20);
            this.Vnostxt.TabIndex = 1;
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(246, 86);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(100, 20);
            this.Rezultat.TabIndex = 2;
            // 
            // Izracunaj
            // 
            this.Izracunaj.Location = new System.Drawing.Point(93, 160);
            this.Izracunaj.Name = "Izracunaj";
            this.Izracunaj.Size = new System.Drawing.Size(75, 23);
            this.Izracunaj.TabIndex = 3;
            this.Izracunaj.Text = "Izračunaj";
            this.Izracunaj.UseVisualStyleBackColor = true;
            this.Izracunaj.Click += new System.EventHandler(this.Izracunaj_Click);
            // 
            // Pocisti
            // 
            this.Pocisti.Location = new System.Drawing.Point(257, 160);
            this.Pocisti.Name = "Pocisti";
            this.Pocisti.Size = new System.Drawing.Size(75, 23);
            this.Pocisti.TabIndex = 4;
            this.Pocisti.Text = "Počisti";
            this.Pocisti.UseVisualStyleBackColor = true;
            this.Pocisti.Click += new System.EventHandler(this.Pocisti_Click);
            // 
            // Vnos
            // 
            this.Vnos.AutoSize = true;
            this.Vnos.Location = new System.Drawing.Point(357, 42);
            this.Vnos.Name = "Vnos";
            this.Vnos.Size = new System.Drawing.Size(30, 13);
            this.Vnos.TabIndex = 5;
            this.Vnos.Text = "EUR";
            this.Vnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sprem
            // 
            this.Sprem.AutoSize = true;
            this.Sprem.Location = new System.Drawing.Point(357, 89);
            this.Sprem.Name = "Sprem";
            this.Sprem.Size = new System.Drawing.Size(30, 13);
            this.Sprem.TabIndex = 6;
            this.Sprem.Text = "USD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GBPB);
            this.groupBox1.Controls.Add(this.JPYB);
            this.groupBox1.Controls.Add(this.USDB);
            this.groupBox1.Location = new System.Drawing.Point(36, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tečaji";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBPB
            // 
            this.GBPB.AutoSize = true;
            this.GBPB.Location = new System.Drawing.Point(27, 64);
            this.GBPB.Name = "GBPB";
            this.GBPB.Size = new System.Drawing.Size(47, 17);
            this.GBPB.TabIndex = 8;
            this.GBPB.Text = "GBP";
            this.GBPB.UseVisualStyleBackColor = true;
            this.GBPB.CheckedChanged += new System.EventHandler(this.GBPB_CheckedChanged);
            // 
            // JPYB
            // 
            this.JPYB.AutoSize = true;
            this.JPYB.Location = new System.Drawing.Point(27, 40);
            this.JPYB.Name = "JPYB";
            this.JPYB.Size = new System.Drawing.Size(44, 17);
            this.JPYB.TabIndex = 7;
            this.JPYB.Text = "JPY";
            this.JPYB.UseVisualStyleBackColor = true;
            this.JPYB.CheckedChanged += new System.EventHandler(this.JPYB_CheckedChanged);
            // 
            // USDB
            // 
            this.USDB.AutoSize = true;
            this.USDB.Checked = true;
            this.USDB.Location = new System.Drawing.Point(27, 17);
            this.USDB.Name = "USDB";
            this.USDB.Size = new System.Drawing.Size(48, 17);
            this.USDB.TabIndex = 6;
            this.USDB.TabStop = true;
            this.USDB.Text = "USD";
            this.USDB.UseVisualStyleBackColor = true;
            this.USDB.CheckedChanged += new System.EventHandler(this.USDB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sprem);
            this.Controls.Add(this.Vnos);
            this.Controls.Add(this.Pocisti);
            this.Controls.Add(this.Izracunaj);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.Vnostxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Vnostxt;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Button Izracunaj;
        private System.Windows.Forms.Button Pocisti;
        private System.Windows.Forms.Label Vnos;
        private System.Windows.Forms.Label Sprem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GBPB;
        private System.Windows.Forms.RadioButton JPYB;
        private System.Windows.Forms.RadioButton USDB;
    }
}

