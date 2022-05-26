using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApprovedExpenseAutomation
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        public Action<string> ExcelMethod { get; set; }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//Kaydedıcegı yer
            dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";//Dosya uzantsıve gorntulecek dosya
            dialog.Title = "Rapor Excel ";
            dialog.FileName = this.Text.Replace("Rapor: ", "");
            dialog.OverwritePrompt = true;//Uzerıne yazma

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ExcelMethod(dialog.FileName);
            
            }
        }
    }
}
