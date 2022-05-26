namespace ManagementApprovedExpenseAutomation
{
    partial class frmKullaniciYonetimi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYonetici = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanicTipi = new System.Windows.Forms.Label();
            this.lblYoneticiAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(876, 585);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKullanicilar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(455, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıclıar";
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 16;
            this.lstKullanicilar.Location = new System.Drawing.Point(8, 23);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(439, 534);
            this.lstKullanicilar.TabIndex = 0;
            this.lstKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKullanicilar_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox3.Size = new System.Drawing.Size(377, 365);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekleme/Güncelleme/Silme";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtAdSoyad);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtKullaniciAd);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtPassword);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbKullaniciTipi);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.cmbYonetici);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(361, 334);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(3, 23);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(356, 36);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanicı Adı";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(3, 85);
            this.txtKullaniciAd.Multiline = true;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(356, 36);
            this.txtKullaniciAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(3, 147);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(356, 36);
            this.txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Tipi";
            // 
            // cmbKullaniciTipi
            // 
            this.cmbKullaniciTipi.FormattingEnabled = true;
            this.cmbKullaniciTipi.Location = new System.Drawing.Point(3, 209);
            this.cmbKullaniciTipi.Name = "cmbKullaniciTipi";
            this.cmbKullaniciTipi.Size = new System.Drawing.Size(356, 24);
            this.cmbKullaniciTipi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yönetici";
            // 
            // cmbYonetici
            // 
            this.cmbYonetici.FormattingEnabled = true;
            this.cmbYonetici.Location = new System.Drawing.Point(3, 259);
            this.cmbYonetici.Name = "cmbYonetici";
            this.cmbYonetici.Size = new System.Drawing.Size(356, 24);
            this.cmbYonetici.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAdd);
            this.flowLayoutPanel3.Controls.Add(this.btnOk);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 289);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(356, 38);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(119, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Güncelle";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(10, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(377, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detay";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAd);
            this.flowLayoutPanel1.Controls.Add(this.lblKullaniciAd);
            this.flowLayoutPanel1.Controls.Add(this.lblSifre);
            this.flowLayoutPanel1.Controls.Add(this.lblKullanicTipi);
            this.flowLayoutPanel1.Controls.Add(this.lblYoneticiAd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 169);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 5);
            this.lblAd.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "lblAd";
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Location = new System.Drawing.Point(6, 27);
            this.lblKullaniciAd.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(91, 17);
            this.lblKullaniciAd.TabIndex = 1;
            this.lblKullaniciAd.Text = "lblKullaniciAd";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(6, 49);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(51, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "lblSifre";
            // 
            // lblKullanicTipi
            // 
            this.lblKullanicTipi.AutoSize = true;
            this.lblKullanicTipi.Location = new System.Drawing.Point(6, 71);
            this.lblKullanicTipi.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.lblKullanicTipi.Name = "lblKullanicTipi";
            this.lblKullanicTipi.Size = new System.Drawing.Size(94, 17);
            this.lblKullanicTipi.TabIndex = 3;
            this.lblKullanicTipi.Text = "lblKullanicTipi";
            // 
            // lblYoneticiAd
            // 
            this.lblYoneticiAd.AutoSize = true;
            this.lblYoneticiAd.Location = new System.Drawing.Point(6, 93);
            this.lblYoneticiAd.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.lblYoneticiAd.Name = "lblYoneticiAd";
            this.lblYoneticiAd.Size = new System.Drawing.Size(89, 17);
            this.lblYoneticiAd.TabIndex = 4;
            this.lblYoneticiAd.Text = "lblYoneticiAd";
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 585);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKullaniciYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanici Yönetimi";
            this.Load += new System.EventHandler(this.frmKullaniciYonetimi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstKullanicilar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKullaniciTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYonetici;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanicTipi;
        private System.Windows.Forms.Label lblYoneticiAd;
    }
}