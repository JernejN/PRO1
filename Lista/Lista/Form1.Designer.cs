namespace Lista
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
            this.gb_tečaji = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lbl_vnos = new System.Windows.Forms.Label();
            this.lbl_izpis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_izračun = new System.Windows.Forms.Button();
            this.btn_izhod = new System.Windows.Forms.Button();
            this.btn_počisti = new System.Windows.Forms.Button();
            this.gb_tečaji.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_tečaji
            // 
            this.gb_tečaji.Controls.Add(this.radioButton3);
            this.gb_tečaji.Controls.Add(this.radioButton2);
            this.gb_tečaji.Controls.Add(this.radioButton1);
            this.gb_tečaji.Location = new System.Drawing.Point(154, 139);
            this.gb_tečaji.Name = "gb_tečaji";
            this.gb_tečaji.Size = new System.Drawing.Size(104, 121);
            this.gb_tečaji.TabIndex = 0;
            this.gb_tečaji.TabStop = false;
            this.gb_tečaji.Text = "Tečaji";
            this.gb_tečaji.Enter += new System.EventHandler(this.gb_tečaji_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USD";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CHF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "GBP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lbl_vnos
            // 
            this.lbl_vnos.AutoSize = true;
            this.lbl_vnos.Location = new System.Drawing.Point(359, 140);
            this.lbl_vnos.Name = "lbl_vnos";
            this.lbl_vnos.Size = new System.Drawing.Size(30, 13);
            this.lbl_vnos.TabIndex = 1;
            this.lbl_vnos.Text = "EUR";
            this.lbl_vnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_izpis
            // 
            this.lbl_izpis.AutoSize = true;
            this.lbl_izpis.Location = new System.Drawing.Point(359, 166);
            this.lbl_izpis.Name = "lbl_izpis";
            this.lbl_izpis.Size = new System.Drawing.Size(0, 13);
            this.lbl_izpis.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_izračun
            // 
            this.btn_izračun.Location = new System.Drawing.Point(435, 234);
            this.btn_izračun.Name = "btn_izračun";
            this.btn_izračun.Size = new System.Drawing.Size(53, 27);
            this.btn_izračun.TabIndex = 5;
            this.btn_izračun.Text = "Pretvori";
            this.btn_izračun.UseVisualStyleBackColor = true;
            this.btn_izračun.Click += new System.EventHandler(this.btn_izračun_Click);
            // 
            // btn_izhod
            // 
            this.btn_izhod.Location = new System.Drawing.Point(320, 233);
            this.btn_izhod.Name = "btn_izhod";
            this.btn_izhod.Size = new System.Drawing.Size(56, 27);
            this.btn_izhod.TabIndex = 6;
            this.btn_izhod.Text = "Izhod";
            this.btn_izhod.UseVisualStyleBackColor = true;
            this.btn_izhod.Click += new System.EventHandler(this.btn_izhod_Click);
            // 
            // btn_počisti
            // 
            this.btn_počisti.Location = new System.Drawing.Point(382, 234);
            this.btn_počisti.Name = "btn_počisti";
            this.btn_počisti.Size = new System.Drawing.Size(47, 26);
            this.btn_počisti.TabIndex = 7;
            this.btn_počisti.Text = "Počisti";
            this.btn_počisti.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_počisti.UseVisualStyleBackColor = true;
            this.btn_počisti.Click += new System.EventHandler(this.btn_počisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 388);
            this.Controls.Add(this.btn_počisti);
            this.Controls.Add(this.btn_izhod);
            this.Controls.Add(this.btn_izračun);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_izpis);
            this.Controls.Add(this.lbl_vnos);
            this.Controls.Add(this.gb_tečaji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_tečaji.ResumeLayout(false);
            this.gb_tečaji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tečaji;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_vnos;
        private System.Windows.Forms.Label lbl_izpis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_izračun;
        private System.Windows.Forms.Button btn_izhod;
        private System.Windows.Forms.Button btn_počisti;
    }
}

