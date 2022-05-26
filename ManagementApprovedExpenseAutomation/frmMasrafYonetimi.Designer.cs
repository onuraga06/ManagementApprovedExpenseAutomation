
namespace ManagementApprovedExpenseAutomation
{
    partial class frmMasrafYonetimi
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfisNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFisDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFisTutar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMsrfTip = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExpnsDelete = new System.Windows.Forms.Button();
            this.btnExpnseUpdate = new System.Windows.Forms.Button();
            this.btnExpnseAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMasraflar = new System.Windows.Forms.ListView();
            this.clmSahb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clbMsrfTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFisNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnubek = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuonay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnured = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuodend = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFisTutar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1121, 430);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(259, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Ekle/Güncelle/Sil";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtfisNumber);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dtpFisDate);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.nudFisTutar);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbMsrfTip);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtAcıklama);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 357);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiş No :";
            // 
            // txtfisNumber
            // 
            this.txtfisNumber.Location = new System.Drawing.Point(3, 20);
            this.txtfisNumber.Multiline = true;
            this.txtfisNumber.Name = "txtfisNumber";
            this.txtfisNumber.Size = new System.Drawing.Size(237, 30);
            this.txtfisNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih :";
            // 
            // dtpFisDate
            // 
            this.dtpFisDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFisDate.Location = new System.Drawing.Point(3, 73);
            this.dtpFisDate.Name = "dtpFisDate";
            this.dtpFisDate.Size = new System.Drawing.Size(237, 22);
            this.dtpFisDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar :";
            // 
            // nudFisTutar
            // 
            this.nudFisTutar.DecimalPlaces = 2;
            this.nudFisTutar.Location = new System.Drawing.Point(3, 118);
            this.nudFisTutar.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudFisTutar.Name = "nudFisTutar";
            this.nudFisTutar.Size = new System.Drawing.Size(237, 22);
            this.nudFisTutar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masraf Tipi";
            // 
            // cmbMsrfTip
            // 
            this.cmbMsrfTip.FormattingEnabled = true;
            this.cmbMsrfTip.Location = new System.Drawing.Point(3, 163);
            this.cmbMsrfTip.Name = "cmbMsrfTip";
            this.cmbMsrfTip.Size = new System.Drawing.Size(237, 24);
            this.cmbMsrfTip.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama";
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Location = new System.Drawing.Point(3, 211);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAcıklama.Size = new System.Drawing.Size(237, 143);
            this.txtAcıklama.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExpnsDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnExpnseUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnExpnseAdd);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 383);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnExpnsDelete
            // 
            this.btnExpnsDelete.Location = new System.Drawing.Point(165, 3);
            this.btnExpnsDelete.Name = "btnExpnsDelete";
            this.btnExpnsDelete.Size = new System.Drawing.Size(75, 36);
            this.btnExpnsDelete.TabIndex = 1;
            this.btnExpnsDelete.Text = "Sil";
            this.btnExpnsDelete.UseVisualStyleBackColor = true;
            // 
            // btnExpnseUpdate
            // 
            this.btnExpnseUpdate.Location = new System.Drawing.Point(84, 3);
            this.btnExpnseUpdate.Name = "btnExpnseUpdate";
            this.btnExpnseUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnExpnseUpdate.TabIndex = 2;
            this.btnExpnseUpdate.Text = "Güncelle";
            this.btnExpnseUpdate.UseVisualStyleBackColor = true;
            this.btnExpnseUpdate.Click += new System.EventHandler(this.btnExpnseUpdate_Click);
            // 
            // btnExpnseAdd
            // 
            this.btnExpnseAdd.Location = new System.Drawing.Point(3, 3);
            this.btnExpnseAdd.Name = "btnExpnseAdd";
            this.btnExpnseAdd.Size = new System.Drawing.Size(75, 36);
            this.btnExpnseAdd.TabIndex = 3;
            this.btnExpnseAdd.Text = "Ekle";
            this.btnExpnseAdd.UseVisualStyleBackColor = true;
            this.btnExpnseAdd.Click += new System.EventHandler(this.btnExpnseAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMasraflar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(858, 430);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masraf Listesi";
            // 
            // lvMasraflar
            // 
            this.lvMasraflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSahb,
            this.clbMsrfTip,
            this.clmTarih,
            this.clmFisNo,
            this.clmTutar,
            this.clmDurum});
            this.lvMasraflar.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMasraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMasraflar.FullRowSelect = true;
            this.lvMasraflar.HideSelection = false;
            this.lvMasraflar.Location = new System.Drawing.Point(8, 23);
            this.lvMasraflar.MultiSelect = false;
            this.lvMasraflar.Name = "lvMasraflar";
            this.lvMasraflar.Size = new System.Drawing.Size(842, 399);
            this.lvMasraflar.TabIndex = 0;
            this.lvMasraflar.UseCompatibleStateImageBehavior = false;
            this.lvMasraflar.View = System.Windows.Forms.View.Details;
            this.lvMasraflar.SelectedIndexChanged += new System.EventHandler(this.lvMasraflar_SelectedIndexChanged);
            // 
            // clmSahb
            // 
            this.clmSahb.Text = "Sahibi";
            this.clmSahb.Width = 120;
            // 
            // clbMsrfTip
            // 
            this.clbMsrfTip.Text = "Masraf Tipi";
            this.clbMsrfTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clbMsrfTip.Width = 100;
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            this.clmTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTarih.Width = 100;
            // 
            // clmFisNo
            // 
            this.clmFisNo.Text = "Fiş No";
            this.clmFisNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmFisNo.Width = 100;
            // 
            // clmTutar
            // 
            this.clmTutar.Text = "Tutar";
            this.clmTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTutar.Width = 100;
            // 
            // clmDurum
            // 
            this.clmDurum.Text = "Durum";
            this.clmDurum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDurum.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnubek,
            this.cmnuonay,
            this.cmnured,
            this.toolStripMenuItem1,
            this.cmnuodend});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 134);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmnubek
            // 
            this.cmnubek.Name = "cmnubek";
            this.cmnubek.Size = new System.Drawing.Size(210, 24);
            this.cmnubek.Text = "Onay Bekliyor";
            this.cmnubek.Click += new System.EventHandler(this.cmnubek_Click);
            // 
            // cmnuonay
            // 
            this.cmnuonay.Name = "cmnuonay";
            this.cmnuonay.Size = new System.Drawing.Size(210, 24);
            this.cmnuonay.Text = "Onaylandı";
            this.cmnuonay.Click += new System.EventHandler(this.cmnuonay_Click);
            // 
            // cmnured
            // 
            this.cmnured.Name = "cmnured";
            this.cmnured.Size = new System.Drawing.Size(210, 24);
            this.cmnured.Text = "Rededildi";
            this.cmnured.Click += new System.EventHandler(this.cmnured_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // cmnuodend
            // 
            this.cmnuodend.Name = "cmnuodend";
            this.cmnuodend.Size = new System.Drawing.Size(210, 24);
            this.cmnuodend.Text = "Ödendi";
            this.cmnuodend.Click += new System.EventHandler(this.cmnuodend_Click);
            // 
            // frmMasrafYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasrafYonetimi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Masraflar";
            this.Load += new System.EventHandler(this.frmMasrafYonetimi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFisTutar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExpnsDelete;
        private System.Windows.Forms.Button btnExpnseUpdate;
        private System.Windows.Forms.Button btnExpnseAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMasraflar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfisNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFisDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFisTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMsrfTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.ColumnHeader clmSahb;
        private System.Windows.Forms.ColumnHeader clbMsrfTip;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmFisNo;
        private System.Windows.Forms.ColumnHeader clmTutar;
        private System.Windows.Forms.ColumnHeader clmDurum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnubek;
        private System.Windows.Forms.ToolStripMenuItem cmnuonay;
        private System.Windows.Forms.ToolStripMenuItem cmnured;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuodend;
    }
}