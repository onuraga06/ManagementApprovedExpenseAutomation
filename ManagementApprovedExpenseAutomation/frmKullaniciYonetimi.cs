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
    public partial class frmKullaniciYonetimi : Form
    {
        List<Users> userList = new List<Users>();
        public frmKullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void frmKullaniciYonetimi_Load(object sender, EventArgs e)
        {
            
            LoadUser(); //Kullanıcı Yukle
            LoadManagers();
            LoadUserType();//Kullanıcı Tıplerını Yukle

        }

        private void LoadManagers() //Yonetıcılerı Combobax a ekle
        {
            cmbYonetici.DataSource = null;
            cmbYonetici.DataSource = GetManager();
            cmbYonetici.DisplayMember = "UserFullName";//cOMBOBAX DA Kullanıcı Adı Gozuksun
            cmbYonetici.ValueMember = "ID";
        }

        private void LoadUserType()
        {
            cmbKullaniciTipi.DataSource = null;
            cmbKullaniciTipi.Items.AddRange(Enum.GetNames(typeof(UsersType)));
            cmbKullaniciTipi.SelectedIndex = 0;
        }

        private void LoadUser()
        {
            //Verılerı Dosyadan Okuyup Geıtrıp LıstBox a yukleme
            userList = FileHelper.ReadFileUsers();///Gelen Dosyayı Oku
            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = userList;
        }
        private List<Users> GetManager()
        {
            List<Users> list = new List<Users>();

            foreach (var item in userList)  //Kullanıcı Listesinde gelen itemin Tipi eşitse yonetıcıye yonetcı olarak list e eklensın.
            {
                if (item.Type == UsersType.manager)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ID = Guid.NewGuid();
            user.UserFullName = txtAdSoyad.Text.Trim();
            user.UserLoginName = txtKullaniciAd.Text.Trim();
            user.UserPassword = txtPassword.Text.Trim();
            user.Type = (UsersType)cmbKullaniciTipi.SelectedIndex;
            user.ManagerID = (Guid)cmbYonetici.SelectedValue;
            userList.Add(user);
            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = userList;
            Clear();

            FileHelper.WriteFileUsers(userList); //Userlıst ı yazdır.Json formatında
            LoadManagers();
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1) //Eğer Bırsey Secılı Degılse Temızle Motedonu cagır ve return cık
            {
                Clear();
                return;
            }
            Users selectUsers = lstKullanicilar.SelectedItem as Users;
            LoadUserData(selectUsers);

        }

        private void LoadUserData(Users selectUsers)
        {
            Clear();
            lblAd.Text = selectUsers.UserFullName;
            lblKullaniciAd.Text = selectUsers.UserLoginName;
            lblKullanicTipi.Text = EnumHelper.GetEnumTypeName(selectUsers.Type);
            lblSifre.Text = selectUsers.UserPassword;
            lblYoneticiAd.Text = GetUserName(selectUsers.ManagerID);
            txtAdSoyad.Text = selectUsers.UserFullName;
            txtKullaniciAd.Text = selectUsers.UserLoginName;
            cmbKullaniciTipi.Text = selectUsers.Type.ToString();
            txtPassword.Text=selectUsers.UserPassword;
            //Eğer Yoneticisi yoksa bos getir varsa secılen verıyı getir
            cmbYonetici.Text = selectUsers.ManagerID != null ? GetUserName(selectUsers.ManagerID) : cmbYonetici.Text = "";



        }

        private string GetUserName(Guid? userID)
        {
            //ID yolluyup bu ıd ye sahıp olan kullanıcıyı getir.
            //Ve o kullanıcının ısmını yazdır. 
            string name = "";
            if (userID != null)
            {
                foreach (Users item in userList)
                {
                    if (item.ID == userID)
                    {
                        name = item.UserFullName;
                        break;
                    }
                }
            }
            else
            {
                name = "";
            }
            
           

            return name;
        }

        private void Clear()
        {
            foreach(Control item in flowLayoutPanel2.Controls)
        {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.Text = "";
            }
            cmbKullaniciTipi.SelectedIndex = -1;
            cmbYonetici.SelectedIndex = -1;


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1) 
            {
                Clear();
                return;
            }
            Users selectUsers = lstKullanicilar.SelectedItem as Users;
            selectUsers.UserFullName = txtAdSoyad.Text.Trim();
            selectUsers.UserLoginName = txtKullaniciAd.Text.Trim();
            selectUsers.UserPassword = txtPassword.Text.Trim();
            selectUsers.Type = (UsersType)cmbKullaniciTipi.SelectedIndex;
            if (cmbYonetici.SelectedValue != null)
            {
                selectUsers.ManagerID = (Guid)cmbYonetici.SelectedValue;
            }
            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = userList;
            FileHelper.WriteFileUsers(userList);
            LoadManagers();
            Clear();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedIndex == -1)
            {
                Clear();
                return;
            }
            Users selectUsers = lstKullanicilar.SelectedItem as Users;
            DialogResult result = MessageBox.Show($"{selectUsers.UserFullName} Kullanıcıyı Silmek İstediğinize Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                //Secılı Kullanıcı Tipi Yonetıcı ise
                if(selectUsers.Type == UsersType.manager)
                {
                    ///Icınde Don ve yonetcının personellerı yonetıcılerıne  null ata
                    ///Eger degılse cık dırek sil
                   
                    foreach (Users item in userList)
                    {
                        if (item.ManagerID == selectUsers.ManagerID)
                        {
                            item.ManagerID = null;
                        }
                    }
                }
                userList.Remove(selectUsers);
                lstKullanicilar.DataSource=null;
                lstKullanicilar.DataSource=userList;
                FileHelper.WriteFileUsers(userList);
                LoadManagers();
            }
        }
    }
}
