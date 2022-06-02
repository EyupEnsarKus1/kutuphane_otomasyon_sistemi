
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
            this.combo_uyeler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kSifre
            // 
            this.txt_kSifre.BackColor = System.Drawing.Color.Azure;
            this.txt_kSifre.Location = new System.Drawing.Point(145, 287);
            this.txt_kSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kSifre.MaxLength = 10;
            this.txt_kSifre.Multiline = true;
            this.txt_kSifre.Name = "txt_kSifre";
            this.txt_kSifre.PasswordChar = '*';
            this.txt_kSifre.Size = new System.Drawing.Size(238, 36);
            this.txt_kSifre.TabIndex = 2;
            this.txt_kSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(61)))));
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_Button.Location = new System.Drawing.Point(160, 339);
            this.login_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(189, 43);
            this.login_Button.TabIndex = 3;
            this.login_Button.Text = "Giriş Yap";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_uyeler
            // 
            this.combo_uyeler.BackColor = System.Drawing.Color.Azure;
            this.combo_uyeler.FormattingEnabled = true;
            this.combo_uyeler.Location = new System.Drawing.Point(145, 255);
            this.combo_uyeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_uyeler.Name = "combo_uyeler";
            this.combo_uyeler.Size = new System.Drawing.Size(238, 24);
            this.combo_uyeler.TabIndex = 7;
            this.combo_uyeler.SelectedIndexChanged += new System.EventHandler(this.combo_uyeler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "GİRİŞ YAP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources.icons8_lock_50;
            this.pictureBox3.Location = new System.Drawing.Point(103, 287);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources.icons8_user_64;
            this.pictureBox2.Location = new System.Drawing.Point(103, 243);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kutuphane_otomasyon_sistemi.Properties.Resources.pixlr_bg_result__4_;
            this.pictureBox1.Location = new System.Drawing.Point(145, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(537, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_uyeler);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.txt_kSifre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ComboBox combo_uyeler;
        private System.Windows.Forms.Label label2;
    }
}

