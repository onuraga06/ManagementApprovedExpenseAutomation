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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            

            string usrName = txtuserNamee.Text.Trim();
            string pssword = txtPasswordd.Text.Trim();
            if (string.IsNullOrEmpty(usrName))
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pssword))
            {
                MessageBox.Show("Şifre Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Users> users = FileHelper.ReadFileUsers();
            foreach (Users item in users)
            {
                if(item.UserLoginName==usrName && item.UserPassword == pssword)
                {
                    Alternating.LoginUser = item;//Degıskenler Classının ıcıne gıt bu kullanıycı yaz
                    //Cunku gırıs yaptıktan sonra bunun bılgısı her yerde tutulması lazım
                    break;
                }
            }
            if(Alternating.LoginUser != null)// Eger Kullanıcı gırıs yaptı ise
            {
                Close();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            


        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
