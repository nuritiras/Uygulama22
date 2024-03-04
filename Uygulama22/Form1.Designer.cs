namespace Uygulama22
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textKitapAdi = new System.Windows.Forms.TextBox();
            this.textKitapYazari = new System.Windows.Forms.TextBox();
            this.textKitapTuru = new System.Windows.Forms.TextBox();
            this.listeVeri = new System.Windows.Forms.ListBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Türü";
            // 
            // textKitapAdi
            // 
            this.textKitapAdi.Location = new System.Drawing.Point(134, 26);
            this.textKitapAdi.Name = "textKitapAdi";
            this.textKitapAdi.Size = new System.Drawing.Size(155, 20);
            this.textKitapAdi.TabIndex = 3;
            // 
            // textKitapYazari
            // 
            this.textKitapYazari.Location = new System.Drawing.Point(134, 54);
            this.textKitapYazari.Name = "textKitapYazari";
            this.textKitapYazari.Size = new System.Drawing.Size(155, 20);
            this.textKitapYazari.TabIndex = 4;
            // 
            // textKitapTuru
            // 
            this.textKitapTuru.Location = new System.Drawing.Point(134, 81);
            this.textKitapTuru.Name = "textKitapTuru";
            this.textKitapTuru.Size = new System.Drawing.Size(155, 20);
            this.textKitapTuru.TabIndex = 5;
            // 
            // listeVeri
            // 
            this.listeVeri.FormattingEnabled = true;
            this.listeVeri.Location = new System.Drawing.Point(317, 26);
            this.listeVeri.Name = "listeVeri";
            this.listeVeri.Size = new System.Drawing.Size(162, 147);
            this.listeVeri.TabIndex = 6;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(134, 129);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Kitap Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(364, 188);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(75, 23);
            this.buttonListele.TabIndex = 8;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 227);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.listeVeri);
            this.Controls.Add(this.textKitapTuru);
            this.Controls.Add(this.textKitapYazari);
            this.Controls.Add(this.textKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKitapAdi;
        private System.Windows.Forms.TextBox textKitapYazari;
        private System.Windows.Forms.TextBox textKitapTuru;
        private System.Windows.Forms.ListBox listeVeri;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonListele;
    }
}

