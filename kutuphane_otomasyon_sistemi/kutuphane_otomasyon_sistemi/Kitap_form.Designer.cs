
namespace kutuphane_otomasyon_sistemi
{
    partial class Kitap_form
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
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayınevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapTürü = new System.Windows.Forms.TextBox();
            this.txtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtKaydet = new System.Windows.Forms.Button();
            this.txtSil = new System.Windows.Forms.Button();
            this.txtİptal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarkodId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(104, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "KİTAP ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(104, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "YAZAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(104, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "YAYINEVİ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKitapAdı.Location = new System.Drawing.Point(206, 80);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(143, 20);
            this.txtKitapAdı.TabIndex = 5;
            // 
            // txtYazar
            // 
            this.txtYazar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYazar.Location = new System.Drawing.Point(206, 116);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(143, 20);
            this.txtYazar.TabIndex = 6;
            // 
            // txtYayınevi
            // 
            this.txtYayınevi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYayınevi.Location = new System.Drawing.Point(206, 152);
            this.txtYayınevi.Name = "txtYayınevi";
            this.txtYayınevi.Size = new System.Drawing.Size(143, 20);
            this.txtYayınevi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(104, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "KİTAP TÜRÜ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(104, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "SAYFA SAYISI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(104, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "RAF";
            // 
            // txtKitapTürü
            // 
            this.txtKitapTürü.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKitapTürü.Location = new System.Drawing.Point(206, 188);
            this.txtKitapTürü.Name = "txtKitapTürü";
            this.txtKitapTürü.Size = new System.Drawing.Size(143, 20);
            this.txtKitapTürü.TabIndex = 11;
            // 
            // txtSayfaSayısı
            // 
            this.txtSayfaSayısı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSayfaSayısı.Location = new System.Drawing.Point(206, 221);
            this.txtSayfaSayısı.Name = "txtSayfaSayısı";
            this.txtSayfaSayısı.Size = new System.Drawing.Size(143, 20);
            this.txtSayfaSayısı.TabIndex = 12;
            // 
            // txtRaf
            // 
            this.txtRaf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRaf.Location = new System.Drawing.Point(206, 257);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(143, 20);
            this.txtRaf.TabIndex = 13;
            // 
            // txtKaydet
            // 
            this.txtKaydet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaydet.Location = new System.Drawing.Point(113, 377);
            this.txtKaydet.Name = "txtKaydet";
            this.txtKaydet.Size = new System.Drawing.Size(102, 38);
            this.txtKaydet.TabIndex = 14;
            this.txtKaydet.Text = "KAYDET";
            this.txtKaydet.UseVisualStyleBackColor = true;
            this.txtKaydet.Click += new System.EventHandler(this.txtKaydet_Click);
            // 
            // txtSil
            // 
            this.txtSil.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSil.Location = new System.Drawing.Point(261, 377);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(102, 38);
            this.txtSil.TabIndex = 15;
            this.txtSil.Text = "SİL";
            this.txtSil.UseVisualStyleBackColor = true;
            // 
            // txtİptal
            // 
            this.txtİptal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtİptal.Location = new System.Drawing.Point(409, 377);
            this.txtİptal.Name = "txtİptal";
            this.txtİptal.Size = new System.Drawing.Size(103, 38);
            this.txtİptal.TabIndex = 16;
            this.txtİptal.Text = "İPTAL";
            this.txtİptal.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(104, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "BARKOD ID";
            // 
            // txtBarkodId
            // 
            this.txtBarkodId.Location = new System.Drawing.Point(206, 294);
            this.txtBarkodId.Name = "txtBarkodId";
            this.txtBarkodId.Size = new System.Drawing.Size(143, 20);
            this.txtBarkodId.TabIndex = 18;
            // 
            // Kitap_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(675, 461);
            this.Controls.Add(this.txtBarkodId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtİptal);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.txtKaydet);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.txtSayfaSayısı);
            this.Controls.Add(this.txtKitapTürü);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYayınevi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Kitap_form";
            this.Text = "Kitap_form";
            this.Load += new System.EventHandler(this.Kitap_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayınevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapTürü;
        private System.Windows.Forms.TextBox txtSayfaSayısı;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.Button txtKaydet;
        private System.Windows.Forms.Button txtSil;
        private System.Windows.Forms.Button txtİptal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBarkodId;
    }
}