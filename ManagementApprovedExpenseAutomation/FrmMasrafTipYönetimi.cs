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
    public partial class FrmMasrafTipYönetimi : Form
    {
        List<string> _expenseType = new List<string>();
        public FrmMasrafTipYönetimi()
        {
            InitializeComponent();
        }
        private void FrmMasrafTipYönetimi_Load(object sender, EventArgs e)
        {
            _expenseType = FileHelper.ReadFileExpenseType();///Gelen Dosyayı Oku
            lstMasrafTipleri.DataSource = null;
            lstMasrafTipleri.DataSource = _expenseType;
        }
        private void btnMasrafAdd_Click(object sender, EventArgs e)
        {
            string typee = txtMasrafTip.Text?.Trim();
            if (string.IsNullOrEmpty(typee))
            {
                MessageBox.Show("Lütfen Bir Masraf Tipi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _expenseType.Add(typee);
            FileHelper.WriteFileExpenseType(_expenseType);
            lstMasrafTipleri.DataSource = null;
            lstMasrafTipleri.DataSource = _expenseType;
            txtMasrafTip.Text = "";
        }

        private void btnMasrafUpdate_Click(object sender, EventArgs e)
        {
            if (lstMasrafTipleri.SelectedIndex == -1)//Secılı olan bırsey yok
            {
                MessageBox.Show("Lütfen Güncelleme İçin Masraf Tipi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string typee = txtMasrafTip.Text?.Trim();
            if (string.IsNullOrEmpty(typee))
            {
                MessageBox.Show("Lütfen Bir Masraf Tipi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_expenseType.Contains(typee))//Yenı Gırelecek deger var ise 
            {
                MessageBox.Show("Masraf Tipi Listede Mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _expenseType[lstMasrafTipleri.SelectedIndex] = typee;//Secılı olana gıt ve degıstır onla
            FileHelper.WriteFileExpenseType(_expenseType);
            lstMasrafTipleri.DataSource = null;
            lstMasrafTipleri.DataSource = _expenseType;
            txtMasrafTip.Text = "";
        }

        private void btnMsrafDelete_Click(object sender, EventArgs e)
        {

            if (lstMasrafTipleri.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Silme İçin Masraf Tipi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string typee = _expenseType[lstMasrafTipleri.SelectedIndex];
            
            DialogResult result =
                MessageBox.Show($"{typee} isim Masrafı Silmek İstediğinize Emin misini?", "Hata", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                _expenseType.RemoveAt(lstMasrafTipleri.SelectedIndex);
                FileHelper.WriteFileExpenseType(_expenseType);
                lstMasrafTipleri.DataSource = null;
                lstMasrafTipleri.DataSource = _expenseType;
                txtMasrafTip.Text = "";
            }
        }

        private void lstMasrafTipleri_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstMasrafTipleri.SelectedIndex > -1)//Eger List Box da Bırse Secılı ıse onu text box a getır
            {
                txtMasrafTip.Text = _expenseType[lstMasrafTipleri.SelectedIndex];
            }
        }
    }
}
