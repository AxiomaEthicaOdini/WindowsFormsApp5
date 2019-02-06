namespace WindowsFormsApp5
{
    partial class FormMenu
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
            this.btnÇalısanlar = new System.Windows.Forms.Button();
            this.btnCalısanGüncelle = new System.Windows.Forms.Button();
            this.btnBordoHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnÇalısanlar
            // 
            this.btnÇalısanlar.Location = new System.Drawing.Point(43, 29);
            this.btnÇalısanlar.Name = "btnÇalısanlar";
            this.btnÇalısanlar.Size = new System.Drawing.Size(153, 65);
            this.btnÇalısanlar.TabIndex = 0;
            this.btnÇalısanlar.Text = "Çalışanlar";
            this.btnÇalısanlar.UseVisualStyleBackColor = true;
            this.btnÇalısanlar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCalısanGüncelle
            // 
            this.btnCalısanGüncelle.Location = new System.Drawing.Point(43, 98);
            this.btnCalısanGüncelle.Name = "btnCalısanGüncelle";
            this.btnCalısanGüncelle.Size = new System.Drawing.Size(153, 65);
            this.btnCalısanGüncelle.TabIndex = 1;
            this.btnCalısanGüncelle.Text = "Çalışanları Güncelle";
            this.btnCalısanGüncelle.UseVisualStyleBackColor = true;
            this.btnCalısanGüncelle.Click += new System.EventHandler(this.btnCalısanGüncelle_Click);
            // 
            // btnBordoHesapla
            // 
            this.btnBordoHesapla.Location = new System.Drawing.Point(43, 167);
            this.btnBordoHesapla.Name = "btnBordoHesapla";
            this.btnBordoHesapla.Size = new System.Drawing.Size(153, 65);
            this.btnBordoHesapla.TabIndex = 2;
            this.btnBordoHesapla.Text = "Bordro Hesapla ";
            this.btnBordoHesapla.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 269);
            this.Controls.Add(this.btnBordoHesapla);
            this.Controls.Add(this.btnCalısanGüncelle);
            this.Controls.Add(this.btnÇalısanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnÇalısanlar;
        private System.Windows.Forms.Button btnCalısanGüncelle;
        private System.Windows.Forms.Button btnBordoHesapla;
    }
}