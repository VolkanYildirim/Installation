namespace Gmail_İle_Mail_Gönderme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbxGondericiBilgileri = new System.Windows.Forms.GroupBox();
            this.txtGondericiGMailSifre = new System.Windows.Forms.TextBox();
            this.txtGondericiGMailAdres = new System.Windows.Forms.TextBox();
            this.lblGondericiGMailSifre = new System.Windows.Forms.Label();
            this.lblGondericiGMailAdres = new System.Windows.Forms.Label();
            this.grpboxAliciBilgileri = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtMesajKonusu = new System.Windows.Forms.TextBox();
            this.txtAliciEMail = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblMesajKonusu = new System.Windows.Forms.Label();
            this.lblAliciEMail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sürümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbxGondericiBilgileri.SuspendLayout();
            this.grpboxAliciBilgileri.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxGondericiBilgileri
            // 
            this.grpbxGondericiBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpbxGondericiBilgileri.CausesValidation = false;
            this.grpbxGondericiBilgileri.Controls.Add(this.txtGondericiGMailSifre);
            this.grpbxGondericiBilgileri.Controls.Add(this.txtGondericiGMailAdres);
            this.grpbxGondericiBilgileri.Controls.Add(this.lblGondericiGMailSifre);
            this.grpbxGondericiBilgileri.Controls.Add(this.lblGondericiGMailAdres);
            this.grpbxGondericiBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxGondericiBilgileri.ForeColor = System.Drawing.Color.Black;
            this.grpbxGondericiBilgileri.Location = new System.Drawing.Point(12, 27);
            this.grpbxGondericiBilgileri.Name = "grpbxGondericiBilgileri";
            this.grpbxGondericiBilgileri.Size = new System.Drawing.Size(309, 106);
            this.grpbxGondericiBilgileri.TabIndex = 0;
            this.grpbxGondericiBilgileri.TabStop = false;
            this.grpbxGondericiBilgileri.Text = "Gönderici Bilgileri";
            // 
            // txtGondericiGMailSifre
            // 
            this.txtGondericiGMailSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGondericiGMailSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGondericiGMailSifre.Location = new System.Drawing.Point(151, 58);
            this.txtGondericiGMailSifre.Name = "txtGondericiGMailSifre";
            this.txtGondericiGMailSifre.PasswordChar = '*';
            this.txtGondericiGMailSifre.Size = new System.Drawing.Size(126, 20);
            this.txtGondericiGMailSifre.TabIndex = 3;
            // 
            // txtGondericiGMailAdres
            // 
            this.txtGondericiGMailAdres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGondericiGMailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGondericiGMailAdres.Location = new System.Drawing.Point(151, 19);
            this.txtGondericiGMailAdres.Name = "txtGondericiGMailAdres";
            this.txtGondericiGMailAdres.Size = new System.Drawing.Size(126, 20);
            this.txtGondericiGMailAdres.TabIndex = 2;
            // 
            // lblGondericiGMailSifre
            // 
            this.lblGondericiGMailSifre.AutoSize = true;
            this.lblGondericiGMailSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGondericiGMailSifre.ForeColor = System.Drawing.Color.Black;
            this.lblGondericiGMailSifre.Location = new System.Drawing.Point(28, 61);
            this.lblGondericiGMailSifre.Name = "lblGondericiGMailSifre";
            this.lblGondericiGMailSifre.Size = new System.Drawing.Size(112, 13);
            this.lblGondericiGMailSifre.TabIndex = 1;
            this.lblGondericiGMailSifre.Text = "Gmail Şifrenizi Giriniz : ";
            // 
            // lblGondericiGMailAdres
            // 
            this.lblGondericiGMailAdres.AutoSize = true;
            this.lblGondericiGMailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGondericiGMailAdres.ForeColor = System.Drawing.Color.Black;
            this.lblGondericiGMailAdres.Location = new System.Drawing.Point(28, 22);
            this.lblGondericiGMailAdres.Name = "lblGondericiGMailAdres";
            this.lblGondericiGMailAdres.Size = new System.Drawing.Size(87, 13);
            this.lblGondericiGMailAdres.TabIndex = 0;
            this.lblGondericiGMailAdres.Text = "Gmail Adresiniz : ";
            // 
            // grpboxAliciBilgileri
            // 
            this.grpboxAliciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.grpboxAliciBilgileri.Controls.Add(this.btnGonder);
            this.grpboxAliciBilgileri.Controls.Add(this.txtMesaj);
            this.grpboxAliciBilgileri.Controls.Add(this.txtMesajKonusu);
            this.grpboxAliciBilgileri.Controls.Add(this.txtAliciEMail);
            this.grpboxAliciBilgileri.Controls.Add(this.lblMesaj);
            this.grpboxAliciBilgileri.Controls.Add(this.lblMesajKonusu);
            this.grpboxAliciBilgileri.Controls.Add(this.lblAliciEMail);
            this.grpboxAliciBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxAliciBilgileri.ForeColor = System.Drawing.Color.Black;
            this.grpboxAliciBilgileri.Location = new System.Drawing.Point(12, 167);
            this.grpboxAliciBilgileri.Name = "grpboxAliciBilgileri";
            this.grpboxAliciBilgileri.Size = new System.Drawing.Size(309, 389);
            this.grpboxAliciBilgileri.TabIndex = 1;
            this.grpboxAliciBilgileri.TabStop = false;
            this.grpboxAliciBilgileri.Text = "Alıcı Bilgileri";
            // 
            // btnGonder
            // 
            this.btnGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.Image")));
            this.btnGonder.Location = new System.Drawing.Point(33, 258);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(244, 90);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.Location = new System.Drawing.Point(119, 118);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(158, 70);
            this.txtMesaj.TabIndex = 8;
            // 
            // txtMesajKonusu
            // 
            this.txtMesajKonusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMesajKonusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesajKonusu.Location = new System.Drawing.Point(119, 81);
            this.txtMesajKonusu.Name = "txtMesajKonusu";
            this.txtMesajKonusu.Size = new System.Drawing.Size(158, 20);
            this.txtMesajKonusu.TabIndex = 7;
            // 
            // txtAliciEMail
            // 
            this.txtAliciEMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAliciEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAliciEMail.Location = new System.Drawing.Point(119, 47);
            this.txtAliciEMail.Name = "txtAliciEMail";
            this.txtAliciEMail.Size = new System.Drawing.Size(158, 20);
            this.txtAliciEMail.TabIndex = 4;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Black;
            this.lblMesaj.Location = new System.Drawing.Point(30, 121);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(59, 13);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesajınız : ";
            // 
            // lblMesajKonusu
            // 
            this.lblMesajKonusu.AutoSize = true;
            this.lblMesajKonusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesajKonusu.ForeColor = System.Drawing.Color.Black;
            this.lblMesajKonusu.Location = new System.Drawing.Point(30, 84);
            this.lblMesajKonusu.Name = "lblMesajKonusu";
            this.lblMesajKonusu.Size = new System.Drawing.Size(83, 13);
            this.lblMesajKonusu.TabIndex = 5;
            this.lblMesajKonusu.Text = "Mesaj Konusu : ";
            // 
            // lblAliciEMail
            // 
            this.lblAliciEMail.AutoSize = true;
            this.lblAliciEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAliciEMail.ForeColor = System.Drawing.Color.Black;
            this.lblAliciEMail.Location = new System.Drawing.Point(30, 50);
            this.lblAliciEMail.Name = "lblAliciEMail";
            this.lblAliciEMail.Size = new System.Drawing.Size(42, 13);
            this.lblAliciEMail.TabIndex = 4;
            this.lblAliciEMail.Text = "E-Mail :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem,
            this.sürümToolStripMenuItem,
            this.kapatToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.kapatToolStripMenuItem.Text = "Hakkında";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem1
            // 
            this.kapatToolStripMenuItem1.Name = "kapatToolStripMenuItem1";
            this.kapatToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem1.Text = "Kapat";
            this.kapatToolStripMenuItem1.Click += new System.EventHandler(this.kapatToolStripMenuItem1_Click);
            // 
            // sürümToolStripMenuItem
            // 
            this.sürümToolStripMenuItem.Name = "sürümToolStripMenuItem";
            this.sürümToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sürümToolStripMenuItem.Text = "Sürüm";
            this.sürümToolStripMenuItem.Click += new System.EventHandler(this.sürümToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 568);
            this.Controls.Add(this.grpboxAliciBilgileri);
            this.Controls.Add(this.grpbxGondericiBilgileri);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Postala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxGondericiBilgileri.ResumeLayout(false);
            this.grpbxGondericiBilgileri.PerformLayout();
            this.grpboxAliciBilgileri.ResumeLayout(false);
            this.grpboxAliciBilgileri.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxGondericiBilgileri;
        private System.Windows.Forms.TextBox txtGondericiGMailSifre;
        private System.Windows.Forms.TextBox txtGondericiGMailAdres;
        private System.Windows.Forms.Label lblGondericiGMailSifre;
        private System.Windows.Forms.Label lblGondericiGMailAdres;
        private System.Windows.Forms.GroupBox grpboxAliciBilgileri;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtMesajKonusu;
        private System.Windows.Forms.TextBox txtAliciEMail;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblMesajKonusu;
        private System.Windows.Forms.Label lblAliciEMail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sürümToolStripMenuItem;
    }
}

