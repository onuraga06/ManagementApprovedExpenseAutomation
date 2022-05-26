
namespace ManagementApprovedExpenseAutomation
{
    partial class FrmMasrafTipYönetimi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMasrafTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMsrafDelete = new System.Windows.Forms.Button();
            this.btnMasrafUpdate = new System.Windows.Forms.Button();
            this.btnMasrafAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMasrafTipleri = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMasrafTip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMsrafDelete);
            this.groupBox1.Controls.Add(this.btnMasrafUpdate);
            this.groupBox1.Controls.Add(this.btnMasrafAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(10, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masraf Düzenleme";
            // 
            // txtMasrafTip
            // 
            this.txtMasrafTip.Location = new System.Drawing.Point(6, 47);
            this.txtMasrafTip.Multiline = true;
            this.txtMasrafTip.Name = "txtMasrafTip";
            this.txtMasrafTip.Size = new System.Drawing.Size(240, 33);
            this.txtMasrafTip.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masraf/Harcama Tipi";
            // 
            // btnMsrafDelete
            // 
            this.btnMsrafDelete.Location = new System.Drawing.Point(467, 47);
            this.btnMsrafDelete.Name = "btnMsrafDelete";
            this.btnMsrafDelete.Size = new System.Drawing.Size(88, 33);
            this.btnMsrafDelete.TabIndex = 2;
            this.btnMsrafDelete.Text = "Sil";
            this.btnMsrafDelete.UseVisualStyleBackColor = true;
            this.btnMsrafDelete.Click += new System.EventHandler(this.btnMsrafDelete_Click);
            // 
            // btnMasrafUpdate
            // 
            this.btnMasrafUpdate.Location = new System.Drawing.Point(357, 47);
            this.btnMasrafUpdate.Name = "btnMasrafUpdate";
            this.btnMasrafUpdate.Size = new System.Drawing.Size(88, 33);
            this.btnMasrafUpdate.TabIndex = 1;
            this.btnMasrafUpdate.Text = "Güncelle";
            this.btnMasrafUpdate.UseVisualStyleBackColor = true;
            this.btnMasrafUpdate.Click += new System.EventHandler(this.btnMasrafUpdate_Click);
            // 
            // btnMasrafAdd
            // 
            this.btnMasrafAdd.Location = new System.Drawing.Point(252, 47);
            this.btnMasrafAdd.Name = "btnMasrafAdd";
            this.btnMasrafAdd.Size = new System.Drawing.Size(88, 33);
            this.btnMasrafAdd.TabIndex = 0;
            this.btnMasrafAdd.Text = "Ekle";
            this.btnMasrafAdd.UseVisualStyleBackColor = true;
            this.btnMasrafAdd.Click += new System.EventHandler(this.btnMasrafAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 10);
            this.panel1.TabIndex = 1;
            // 
            // lstMasrafTipleri
            // 
            this.lstMasrafTipleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasrafTipleri.FormattingEnabled = true;
            this.lstMasrafTipleri.ItemHeight = 16;
            this.lstMasrafTipleri.Location = new System.Drawing.Point(10, 10);
            this.lstMasrafTipleri.Name = "lstMasrafTipleri";
            this.lstMasrafTipleri.Size = new System.Drawing.Size(561, 320);
            this.lstMasrafTipleri.TabIndex = 0;
            this.lstMasrafTipleri.SelectedIndexChanged += new System.EventHandler(this.lstMasrafTipleri_SelectedIndexChanged);
            // 
            // FrmMasrafTipYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.lstMasrafTipleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMasrafTipYönetimi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Masraf Tipleri";
            this.Load += new System.EventHandler(this.FrmMasrafTipYönetimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMasrafTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMsrafDelete;
        private System.Windows.Forms.Button btnMasrafUpdate;
        private System.Windows.Forms.Button btnMasrafAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMasrafTipleri;
    }
}