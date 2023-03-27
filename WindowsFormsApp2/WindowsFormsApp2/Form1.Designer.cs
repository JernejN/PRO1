namespace WindowsFormsApp2
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
            this.txt_vnos = new System.Windows.Forms.TextBox();
            this.btn_pisava = new System.Windows.Forms.Button();
            this.btn_barva = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // txt_vnos
            // 
            this.txt_vnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_vnos.Location = new System.Drawing.Point(353, 250);
            this.txt_vnos.Name = "txt_vnos";
            this.txt_vnos.Size = new System.Drawing.Size(406, 31);
            this.txt_vnos.TabIndex = 0;
            // 
            // btn_pisava
            // 
            this.btn_pisava.Location = new System.Drawing.Point(675, 316);
            this.btn_pisava.Name = "btn_pisava";
            this.btn_pisava.Size = new System.Drawing.Size(84, 45);
            this.btn_pisava.TabIndex = 1;
            this.btn_pisava.Text = "Pisava";
            this.btn_pisava.UseVisualStyleBackColor = true;
            this.btn_pisava.Click += new System.EventHandler(this.btn_pisava_Click);
            // 
            // btn_barva
            // 
            this.btn_barva.Location = new System.Drawing.Point(585, 316);
            this.btn_barva.Name = "btn_barva";
            this.btn_barva.Size = new System.Drawing.Size(84, 45);
            this.btn_barva.TabIndex = 2;
            this.btn_barva.Text = "Barva";
            this.btn_barva.UseVisualStyleBackColor = true;
            this.btn_barva.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 607);
            this.Controls.Add(this.btn_barva);
            this.Controls.Add(this.btn_pisava);
            this.Controls.Add(this.txt_vnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vnos;
        private System.Windows.Forms.Button btn_pisava;
        private System.Windows.Forms.Button btn_barva;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

