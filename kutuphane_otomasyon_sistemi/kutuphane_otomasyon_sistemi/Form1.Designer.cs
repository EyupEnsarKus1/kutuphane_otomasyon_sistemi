
namespace kutuphane_otomasyon_sistemi
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
            this.txt_kSifre = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_uyeler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kSifre
            // 
            this.txt_kSifre.Location = new System.Drawing.Point(315, 274);
            this.txt_kSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kSifre.Multiline = true;
            this.txt_kSifre.Name = "txt_kSifre";
            this.txt_kSifre.Size = new System.Drawing.Size(199, 52);
            this.txt_kSifre.TabIndex = 2;
            this.txt_kSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(315, 345);
            this.login_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(199, 52);
            this.login_Button.TabIndex = 3;
            this.login_Button.Text = "Giriş Yap";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(364, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifremi Unuttum?";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(253, 274);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources.id_card;
            this.pictureBox2.Location = new System.Drawing.Point(253, 185);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(341, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // combo_uyeler
            // 
            this.combo_uyeler.FormattingEnabled = true;
            this.combo_uyeler.Location = new System.Drawing.Point(341, 185);
            this.combo_uyeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_uyeler.Name = "combo_uyeler";
            this.combo_uyeler.Size = new System.Drawing.Size(121, 24);
            this.combo_uyeler.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_uyeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.txt_kSifre);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_kSifre;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_uyeler;
    }
}

