namespace Pretvornik
{
    partial class Pretvornik
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
            this.txt_vnos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pretvori = new System.Windows.Forms.Button();
            this.txt_clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_vnos
            // 
            this.txt_vnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_vnos.Location = new System.Drawing.Point(376, 211);
            this.txt_vnos.Name = "txt_vnos";
            this.txt_vnos.Size = new System.Drawing.Size(358, 31);
            this.txt_vnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(371, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretvornik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_pretvori
            // 
            this.btn_pretvori.Location = new System.Drawing.Point(671, 264);
            this.btn_pretvori.Name = "btn_pretvori";
            this.btn_pretvori.Size = new System.Drawing.Size(63, 34);
            this.btn_pretvori.TabIndex = 2;
            this.btn_pretvori.Text = "Binarno";
            this.btn_pretvori.UseVisualStyleBackColor = true;
            this.btn_pretvori.Click += new System.EventHandler(this.btn_pretvori_Click);
            // 
            // txt_clean
            // 
            this.txt_clean.Location = new System.Drawing.Point(578, 264);
            this.txt_clean.Name = "txt_clean";
            this.txt_clean.Size = new System.Drawing.Size(75, 34);
            this.txt_clean.TabIndex = 3;
            this.txt_clean.Text = "Počisti";
            this.txt_clean.UseVisualStyleBackColor = true;
            this.txt_clean.Click += new System.EventHandler(this.txt_clean_Click);
            // 
            // Pretvornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 587);
            this.Controls.Add(this.txt_clean);
            this.Controls.Add(this.btn_pretvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vnos);
            this.Name = "Pretvornik";
            this.Text = "Pretvornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pretvori;
        private System.Windows.Forms.Button txt_clean;
    }
}

