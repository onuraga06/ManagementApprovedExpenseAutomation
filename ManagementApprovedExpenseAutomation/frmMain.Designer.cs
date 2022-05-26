namespace ManagementApprovedExpenseAutomation
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOturumuKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYönetim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKullaniciYönetim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasrafHarcamaTipi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasrafYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasraflar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonelRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasrafRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygulamaHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblGirisYapan = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuYönetim,
            this.menuMasrafYonetimi,
            this.menuRapor,
            this.mnuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOturumuKapat,
            this.toolStripMenuItem1,
            this.menuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(64, 24);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuOturumuKapat
            // 
            this.mnuOturumuKapat.Name = "mnuOturumuKapat";
            this.mnuOturumuKapat.Size = new System.Drawing.Size(193, 26);
            this.mnuOturumuKapat.Text = "Oturumu Kapat";
            this.mnuOturumuKapat.Click += new System.EventHandler(this.mnuOturumuKapat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(193, 26);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // mnuYönetim
            // 
            this.mnuYönetim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKullaniciYönetim,
            this.mnuMasrafHarcamaTipi});
            this.mnuYönetim.Name = "mnuYönetim";
            this.mnuYönetim.Size = new System.Drawing.Size(77, 24);
            this.mnuYönetim.Text = "Yönetim";
            // 
            // mnuKullaniciYönetim
            // 
            this.mnuKullaniciYönetim.Name = "mnuKullaniciYönetim";
            this.mnuKullaniciYönetim.Size = new System.Drawing.Size(249, 26);
            this.mnuKullaniciYönetim.Text = "Kulanıcı Yönetimi";
            this.mnuKullaniciYönetim.Click += new System.EventHandler(this.mnuKullaniciYönetim_Click);
            // 
            // mnuMasrafHarcamaTipi
            // 
            this.mnuMasrafHarcamaTipi.Name = "mnuMasrafHarcamaTipi";
            this.mnuMasrafHarcamaTipi.Size = new System.Drawing.Size(249, 26);
            this.mnuMasrafHarcamaTipi.Text = "Masraf/Harcama Tipleri";
            this.mnuMasrafHarcamaTipi.Click += new System.EventHandler(this.mnuMasrafHarcamaTipi_Click);
            // 
            // menuMasrafYonetimi
            // 
            this.menuMasrafYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasraflar});
            this.menuMasrafYonetimi.Name = "menuMasrafYonetimi";
            this.menuMasrafYonetimi.Size = new System.Drawing.Size(130, 24);
            this.menuMasrafYonetimi.Text = "Masraf Yönetimi";
            // 
            // mnuMasraflar
            // 
            this.mnuMasraflar.Name = "mnuMasraflar";
            this.mnuMasraflar.Size = new System.Drawing.Size(154, 26);
            this.mnuMasraflar.Text = "Masraflar";
            this.mnuMasraflar.Click += new System.EventHandler(this.mnuMasraflar_Click);
            // 
            // menuRapor
            // 
            this.menuRapor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonelRapor,
            this.menuMasrafRapor});
            this.menuRapor.Name = "menuRapor";
            this.menuRapor.Size = new System.Drawing.Size(80, 24);
            this.menuRapor.Text = "Raporlar";
            // 
            // menuPersonelRapor
            // 
            this.menuPersonelRapor.Name = "menuPersonelRapor";
            this.menuPersonelRapor.Size = new System.Drawing.Size(255, 26);
            this.menuPersonelRapor.Text = "Personel Raporu";
            this.menuPersonelRapor.Click += new System.EventHandler(this.menuPersonelRapor_Click);
            // 
            // menuMasrafRapor
            // 
            this.menuMasrafRapor.Name = "menuMasrafRapor";
            this.menuMasrafRapor.Size = new System.Drawing.Size(255, 26);
            this.menuMasrafRapor.Text = "Masraf/Harcama Raporu";
            this.menuMasrafRapor.Click += new System.EventHandler(this.menuMasrafRapor_Click);
            // 
            // mnuHakkinda
            // 
            this.mnuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygulamaHakkinda});
            this.mnuHakkinda.Name = "mnuHakkinda";
            this.mnuHakkinda.Size = new System.Drawing.Size(85, 24);
            this.mnuHakkinda.Text = "Hakkında";
            // 
            // mnuUygulamaHakkinda
            // 
            this.mnuUygulamaHakkinda.Name = "mnuUygulamaHakkinda";
            this.mnuUygulamaHakkinda.Size = new System.Drawing.Size(225, 26);
            this.mnuUygulamaHakkinda.Text = "Uygulama Hakkında";
            this.mnuUygulamaHakkinda.Click += new System.EventHandler(this.mnuUygulamaHakkinda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGirisYapan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1016, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(27, 20);
            this.lblGirisYapan.Text = "---";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Expense Automation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuOturumuKapat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuYönetim;
        private System.Windows.Forms.ToolStripMenuItem mnuKullaniciYönetim;
        private System.Windows.Forms.ToolStripMenuItem mnuMasrafHarcamaTipi;
        private System.Windows.Forms.ToolStripMenuItem menuMasrafYonetimi;
        private System.Windows.Forms.ToolStripMenuItem mnuMasraflar;
        private System.Windows.Forms.ToolStripMenuItem menuRapor;
        private System.Windows.Forms.ToolStripMenuItem menuPersonelRapor;
        private System.Windows.Forms.ToolStripMenuItem menuMasrafRapor;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem mnuUygulamaHakkinda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblGirisYapan;
    }
}