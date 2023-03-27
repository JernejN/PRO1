namespace LikiApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Stranicatxt = new System.Windows.Forms.TextBox();
            this.ObKvadratatxt = new System.Windows.Forms.TextBox();
            this.PlKvadrattxt = new System.Windows.Forms.TextBox();
            this.IzracunKvadrat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Polmertxt = new System.Windows.Forms.TextBox();
            this.ObKrogtxt = new System.Windows.Forms.TextBox();
            this.PlKrogtxt = new System.Windows.Forms.TextBox();
            this.IzracunajKrog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stranica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Obseg Kvadrata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ploščina Kvadrata";
            // 
            // Stranicatxt
            // 
            this.Stranicatxt.Location = new System.Drawing.Point(266, 48);
            this.Stranicatxt.Name = "Stranicatxt";
            this.Stranicatxt.Size = new System.Drawing.Size(100, 20);
            this.Stranicatxt.TabIndex = 3;
            // 
            // ObKvadratatxt
            // 
            this.ObKvadratatxt.Location = new System.Drawing.Point(266, 98);
            this.ObKvadratatxt.Name = "ObKvadratatxt";
            this.ObKvadratatxt.Size = new System.Drawing.Size(100, 20);
            this.ObKvadratatxt.TabIndex = 4;
            // 
            // PlKvadrattxt
            // 
            this.PlKvadrattxt.Location = new System.Drawing.Point(266, 141);
            this.PlKvadrattxt.Name = "PlKvadrattxt";
            this.PlKvadrattxt.Size = new System.Drawing.Size(100, 20);
            this.PlKvadrattxt.TabIndex = 5;
            // 
            // IzracunKvadrat
            // 
            this.IzracunKvadrat.Location = new System.Drawing.Point(265, 193);
            this.IzracunKvadrat.Name = "IzracunKvadrat";
            this.IzracunKvadrat.Size = new System.Drawing.Size(101, 30);
            this.IzracunKvadrat.TabIndex = 6;
            this.IzracunKvadrat.Text = "Izračunaj kvadrat";
            this.IzracunKvadrat.UseVisualStyleBackColor = true;
            this.IzracunKvadrat.Click += new System.EventHandler(this.IzracunKvadrat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Polmer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(61, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "ObsegKroga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(61, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "PloscinaKroga";
            // 
            // Polmertxt
            // 
            this.Polmertxt.Location = new System.Drawing.Point(259, 274);
            this.Polmertxt.Name = "Polmertxt";
            this.Polmertxt.Size = new System.Drawing.Size(100, 20);
            this.Polmertxt.TabIndex = 10;
            // 
            // ObKrogtxt
            // 
            this.ObKrogtxt.Location = new System.Drawing.Point(259, 312);
            this.ObKrogtxt.Name = "ObKrogtxt";
            this.ObKrogtxt.Size = new System.Drawing.Size(100, 20);
            this.ObKrogtxt.TabIndex = 11;
            // 
            // PlKrogtxt
            // 
            this.PlKrogtxt.Location = new System.Drawing.Point(259, 349);
            this.PlKrogtxt.Name = "PlKrogtxt";
            this.PlKrogtxt.Size = new System.Drawing.Size(100, 20);
            this.PlKrogtxt.TabIndex = 12;
            // 
            // IzracunajKrog
            // 
            this.IzracunajKrog.Location = new System.Drawing.Point(265, 398);
            this.IzracunajKrog.Name = "IzracunajKrog";
            this.IzracunajKrog.Size = new System.Drawing.Size(101, 32);
            this.IzracunajKrog.TabIndex = 13;
            this.IzracunajKrog.Text = "Izračunaj Krog";
            this.IzracunajKrog.UseVisualStyleBackColor = true;
            this.IzracunajKrog.Click += new System.EventHandler(this.IzracunajKrog_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(459, 476);
            this.Controls.Add(this.IzracunajKrog);
            this.Controls.Add(this.PlKrogtxt);
            this.Controls.Add(this.ObKrogtxt);
            this.Controls.Add(this.Polmertxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IzracunKvadrat);
            this.Controls.Add(this.PlKvadrattxt);
            this.Controls.Add(this.ObKvadratatxt);
            this.Controls.Add(this.Stranicatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Stranicatxt;
        private System.Windows.Forms.TextBox ObKvadratatxt;
        private System.Windows.Forms.TextBox PlKvadrattxt;
        private System.Windows.Forms.Button IzracunKvadrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Polmertxt;
        private System.Windows.Forms.TextBox ObKrogtxt;
        private System.Windows.Forms.TextBox PlKrogtxt;
        private System.Windows.Forms.Button IzracunajKrog;
    }
}

