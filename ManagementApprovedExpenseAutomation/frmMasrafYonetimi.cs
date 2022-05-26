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
    public partial class frmMasrafYonetimi : Form
    {
        List<Expense> expenseList = new List<Expense>();
        List<string> expenseTypeList = new List<string>();
        List<Users> userList = new List<Users>();

        public frmMasrafYonetimi()
        {
            InitializeComponent();
        }

        private void frmMasrafYonetimi_Load(object sender, EventArgs e)
        {
            LoadUser();
            LoadExpenseType();
            LoadListView();
        }

        private void LoadUser()
        {
            userList = FileHelper.ReadFileUsers();
        }

        private void LoadExpenseType()
        {
            expenseTypeList = FileHelper.ReadFileExpenseType();
            cmbMsrfTip.DataSource = null;
            cmbMsrfTip.DataSource = expenseTypeList;
        }

        private void LoadListView()
        {
            expenseList = FileHelper.ReadFileExpense();
            lvMasraflar.Items.Clear();

            switch (Alternating.LoginUser.Type)
            {
                case UsersType.manager:
                    List<Guid> expenseUsersID = new List<Guid>();
                    expenseUsersID.Add(Alternating.LoginUser.ID);
                    foreach (Users user in userList)
                    {
                        if (user.ManagerID == Alternating.LoginUser.ID)
                        {
                            expenseUsersID.Add(user.ID);
                        }
                    }
                    foreach (Expense expense in expenseList)
                    {
                        if (expenseUsersID.Contains(expense.UsersID))
                        {
                            AddListView(expense);
                        }

                    }
                    break;
                case UsersType.purser:
                    foreach (Expense expense in expenseList)
                    {
                        if (expense.Status == ExpenseStatus.Onaylandı)
                        {
                            AddListView(expense);
                        }
                    }
                    break;
                case UsersType.employee:
                    foreach (Expense expense in expenseList)
                    {
                        if (expense.UsersID == Alternating.LoginUser.ID)
                        {
                            AddListView(expense);
                        }
                    }
                    break;

                case UsersType.admin:
                default:
                    break;
            }
        }

        private void AddListView(Expense expense)
        {
            ListViewItem item = new ListViewItem();
            item.Text = UserProcess.GetUserFullName(expense.UsersID);
            item.SubItems.Add(expense.ExpenseType);
            item.SubItems.Add(expense.InvoiceInfo.DateTime.ToShortDateString());
            item.SubItems.Add(expense.InvoiceInfo.Number);
            item.SubItems.Add(expense.InvoiceInfo.Price.ToString());
            item.SubItems.Add(expense.Status.ToString());
            item.Tag = expense;
            lvMasraflar.Items.Add(item);
        }

        private void btnExpnseAdd_Click(object sender, EventArgs e)
        {
            string invoiceNumber = txtfisNumber.Text;
            string description = txtAcıklama.Text;
            DateTime date = dtpFisDate.Value.Date;
            decimal price = nudFisTutar.Value;
            string expenseType = cmbMsrfTip.Text;

            Invoice invoice = new Invoice
            {
                Number = invoiceNumber,
                DateTime = date,
                Price = price

            };
            ExpenseStatus status = (Alternating.LoginUser.ManagerID == null) ? ExpenseStatus.Onaylandı : ExpenseStatus.OnayBekliyor;
            Expense expense = new Expense
            {
                ID = Guid.NewGuid(),
                InvoiceInfo = invoice,
                Description = description,
                ExpenseType = expenseType,
                Status = status,
                UsersID = Alternating.LoginUser.ID
            };
            expenseList.Add(expense);
            FileHelper.WriteFileExpense(expenseList);
            LoadListView();
        }

        private void lvMasraflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)//Secılen ındex bos mu ve count 1 den buyuk mu
            {
                int index = lvMasraflar.SelectedIndices[0];//Secılen ındexı ıcıne at
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];//secılı kolon

                Expense expense = listViewItem.Tag as Expense;//Masraf nesnesını almıstık onu ıcıne attık

                if (expense != null)
                {
                    txtfisNumber.Text = expense.InvoiceInfo.Number;
                    txtAcıklama.Text = expense.Description;
                    dtpFisDate.Value = expense.InvoiceInfo.DateTime;
                    nudFisTutar.Value = expense.InvoiceInfo.Price;
                    cmbMsrfTip.Text = expense.ExpenseType;
                }

            }
        }
        private void btnExpnseUpdate_Click(object sender, EventArgs e)
        {

            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                int index = lvMasraflar.SelectedIndices[0];
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];
                Expense expense = listViewItem.Tag as Expense;
                if (expense != null)
                {
                    if (expense.UsersID != Alternating.LoginUser.ID)
                    {
                        MessageBox.Show("İzniniz Bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (expense.Status == ExpenseStatus.OnayBekliyor || (Alternating.LoginUser.ManagerID == null && expense.Status == ExpenseStatus.Onaylandı))
                    {
                        string invoiceNumber = txtfisNumber.Text;
                        string description = txtAcıklama.Text;
                        DateTime date = dtpFisDate.Value.Date;
                        decimal price = nudFisTutar.Value;
                        string expenseType = cmbMsrfTip.Text;

                        expense.InvoiceInfo.Number = invoiceNumber;
                        expense.Description = description;
                        expense.InvoiceInfo.DateTime = date;
                        expense.InvoiceInfo.Price = price;
                        expense.ExpenseType = expenseType;

                        FileHelper.WriteFileExpense(expenseList);
                        LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Yapmaya Uygun Değildir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            cmnubek.Enabled = false;
            cmnuodend.Enabled = false;
            cmnuonay.Enabled = false;
            cmnured.Enabled = false;
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                switch (Alternating.LoginUser.Type)
                {
                    case UsersType.manager:
                        cmnubek.Enabled = true;
                        cmnuonay.Enabled = true;
                        cmnured.Enabled = true;
                        break;
                    case UsersType.purser:
                        cmnuodend.Enabled = true;
                        break;
                    case UsersType.employee:
                    case UsersType.admin:
                    default:
                        break;
                }
                int index = lvMasraflar.SelectedIndices[0];//Secılen ındexı ıcıne at
                ListViewItem listViewItem = lvMasraflar.SelectedItems[0];//secılı kolon
                Expense expense = listViewItem.Tag as Expense;
                switch (expense.Status)
                {
                    case ExpenseStatus.OnayBekliyor:
                        cmnubek.Enabled = false;
                        break;
                    case ExpenseStatus.Onaylandı:
                        cmnubek.Enabled = false;
                        break;
                    case ExpenseStatus.Red:
                        cmnured.Enabled = false;
                        break;
                    case ExpenseStatus.Odendi:
                        cmnubek.Enabled = false;
                        cmnuodend.Enabled = false;
                        cmnuonay.Enabled = false;
                        cmnured.Enabled = false;
                        break;
                }

            }
        }

        private void cmnubek_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Expense expense = lvMasraflar.SelectedItems[0].Tag as Expense;
                expense.Status = ExpenseStatus.OnayBekliyor;
                FileHelper.WriteFileExpense(expenseList);
                LoadListView();

            }
        }

        private void cmnuonay_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Expense expese = lvMasraflar.SelectedItems[0].Tag as Expense;
                expese.Status = ExpenseStatus.Onaylandı;
                FileHelper.WriteFileExpense(expenseList);
                LoadListView();

            }
        }

        private void cmnured_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Expense expese = lvMasraflar.SelectedItems[0].Tag as Expense;
                expese.Status = ExpenseStatus.Red;
                FileHelper.WriteFileExpense(expenseList);
                LoadListView();

            }
        }

        private void cmnuodend_Click(object sender, EventArgs e)
        {
            if (lvMasraflar.SelectedIndices != null && lvMasraflar.SelectedIndices.Count > 0)
            {
                Expense expese = lvMasraflar.SelectedItems[0].Tag as Expense;
                expese.Status = ExpenseStatus.Odendi;
                FileHelper.WriteFileExpense(expenseList);
                LoadListView();

            }
        }
    }


}

