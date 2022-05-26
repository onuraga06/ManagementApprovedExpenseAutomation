
namespace ManagementApprovedExpenseAutomation
{
    partial class frmGiris
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
            this.txtPassowrd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserNamee = new System.Windows.Forms.TextBox();
            this.txtPasswordd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassowrd
            // 
            this.txtPassowrd.AutoSize = true;
            this.txtPassowrd.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassowrd.Location = new System.Drawing.Point(28, 219);
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.Size = new System.Drawing.Size(80, 21);
            this.txtPassowrd.TabIndex = 0;
            this.txtPassowrd.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // txtuserNamee
            // 
            this.txtuserNamee.Location = new System.Drawing.Point(132, 156);
            this.txtuserNamee.Multiline = true;
            this.txtuserNamee.Name = "txtuserNamee";
            this.txtuserNamee.Size = new System.Drawing.Size(246, 35);
            this.txtuserNamee.TabIndex = 2;
            // 
            // txtPasswordd
            // 
            this.txtPasswordd.Location = new System.Drawing.Point(132, 209);
            this.txtPasswordd.Multiline = true;
            this.txtPasswordd.Name = "txtPasswordd";
            this.txtPasswordd.PasswordChar = '*';
            this.txtPasswordd.Size = new System.Drawing.Size(246, 34);
            this.txtPasswordd.TabIndex = 3;
            
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(171, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGİN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagementApprovedExpenseAutomation.Properties.Resources._149071;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordd);
            this.Controls.Add(this.txtuserNamee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassowrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPassowrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserNamee;
        private System.Windows.Forms.TextBox txtPasswordd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}