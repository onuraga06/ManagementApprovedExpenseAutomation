using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApprovedExpenseAutomation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuKullaniciYönetim_Click(object sender, EventArgs e)
        {

            frmKullaniciYonetimi f = new frmKullaniciYonetimi();
            f.MdiParent = this;
            f.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           // AppsSettingsAdmin();//Appsetting Klasoru ıcıne kendımız admın gırısı yaptık. 

            //Ilk Gırs Ekranın ac
            frmGiris frm = new frmGiris();
            frm.MdiParent = this;
            frm.FormClosed += Frm_FormClosed;//Gırıs formu kapandıgında bu metodda gıt
            frm.Show();
        }

        private static void AppsSettingsAdmin()
        {
            string adminLoginName = ConfigurationManager.AppSettings["SystemAdmin"];
            string adminPassword = ConfigurationManager.AppSettings["AdminPasword"];
            bool logAdmin = false;

            List<Users> userss = FileHelper.ReadFileUsers();
            foreach (Users item in userss)//Kullanıclar ıcınde tara yoksa ekle varsa ekleme
            {
                if (item.UserLoginName == adminLoginName)
                {
                    logAdmin = true;
                    break;
                }
            }
            if (logAdmin == false)//admin kullancısı yoksa eklesın yoksa eklemesın
            {
                userss.Add(new Users
                {
                    ID = Guid.NewGuid(),
                    UserLoginName = adminLoginName,
                    UserPassword = adminPassword,
                    UserFullName = "SystemAdmin",
                    Type = UsersType.admin
                });
                FileHelper.WriteFileUsers(userss);
            }
           
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Eger Gırıs yapıldıdıysa Menuyu gorunur yap 
            if (Alternating.LoginUser != null)
            {
                menuStrip1.Visible = true;
                lblGirisYapan.Text = $"{Alternating.LoginUser.UserFullName}-{EnumHelper.GetEnumTypeName(Alternating.LoginUser.Type)}";
                mnuYönetim.Visible = false;
                menuMasrafYonetimi.Visible = false;
                menuRapor.Visible = false;
                switch (Alternating.LoginUser.Type)
                {
                    case UsersType.admin:
                        mnuYönetim.Visible = true;
                        break;
                    case UsersType.manager:
                        menuMasrafYonetimi.Visible = true;
                        menuRapor.Visible = true;
                        break;
                    case UsersType.purser:
                        menuMasrafYonetimi.Visible = true;
                        break;
                    case UsersType.employee:
                        menuMasrafYonetimi.Visible = true;
                        break;
                    default:
                        break;

                }
            }
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuOturumuKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Oturumu Kapatmak İstediğinize Emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Alternating.LoginUser = null;
                lblGirisYapan.Text = "---";
                foreach (Form item in this.MdiChildren)//Formlarda DOn //Acık Olan Ekranları Kapat
                {
                    item.Close();
                }
                menuStrip1.Visible = false;
                frmGiris frm = new frmGiris();
                frm.MdiParent = this;
                frm.FormClosed += Frm_FormClosed;
                frm.Show();
            }
        }

        private void mnuUygulamaHakkinda_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMasraflar_Click(object sender, EventArgs e)
        {
            frmMasrafYonetimi frm = new frmMasrafYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMasrafHarcamaTipi_Click(object sender, EventArgs e)
        {
            FrmMasrafTipYönetimi frm = new FrmMasrafTipYönetimi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuPersonelRapor_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.Text = "Rapor: Personel Toplam Harcama";
            frm.MdiParent = this;
            List<EmployeeTotalSpend> data = ReportProcess.EmployeeTotalReport();
            frm.ExcelMethod = (filename) =>
              {
                  new ExcelMapper().Save(filename, data, "veri");
              };
            
            frm.dgvRapor.DataSource = null;
            frm.dgvRapor.DataSource = data;
            
            frm.Show();

        }

        private void menuMasrafRapor_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            frm.Text = "Rapor: Masraf Tipine Göre Toplam Harcama";
            frm.MdiParent = this;
            List<ExpenseTypeTotalSpend> data = ReportProcess.ExpenseTypeTotalReport();
            frm.ExcelMethod = (filename) =>
            {
                new ExcelMapper().Save(filename, data, "veri");
            };

            frm.dgvRapor.DataSource = null;
            frm.dgvRapor.DataSource = data;

            frm.Show();
        }
    }
}
