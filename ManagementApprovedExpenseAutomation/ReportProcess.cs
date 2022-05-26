using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApprovedExpenseAutomation
{
    public class ReportProcess
    {
        public static List<EmployeeTotalSpend> EmployeeTotalReport()
        {
            List<Expense> expenseList = FileHelper.ReadFileExpense();
            List<Users> userList = FileHelper.ReadFileUsers();
            List<EmployeeTotalSpend> employeeTotalSpendsList = new List<EmployeeTotalSpend>();
            //Tüm Masraflarda gez onun masrafı varsa ekle yoksa kayıt olustur.
            foreach (Expense expense in expenseList)
            {
                bool added = false;
                foreach (EmployeeTotalSpend item in employeeTotalSpendsList)
                {
                    if (item.EmployeeID == expense.UsersID)
                    {
                        item.TotalPrice += expense.InvoiceInfo.Price;
                        added = true;
                        break;
                    }
                }
                if (added == false)
                {
                    employeeTotalSpendsList.Add(new EmployeeTotalSpend
                    {
                        EmployeeID = expense.UsersID,
                        TotalPrice = expense.InvoiceInfo.Price,
                        EmployeeName = UserProcess.GetUserFullName(expense.UsersID)
                    }); 
                }
            }
            return employeeTotalSpendsList;

        }
        public static List<ExpenseTypeTotalSpend> ExpenseTypeTotalReport()
        {
            List<Expense> expenseList = FileHelper.ReadFileExpense();
            List<ExpenseTypeTotalSpend> expenseTypeTotalSpendsList = new List<ExpenseTypeTotalSpend>();
            //Tüm Masraflarda gez onun masrafı varsa ekle yoksa kayıt olustur.
            foreach (Expense expense in expenseList)
            {
                bool added = false;
                foreach (ExpenseTypeTotalSpend item in expenseTypeTotalSpendsList)
                {
                    if (item.ExpenseType == expense.ExpenseType)
                    {
                        item.TotalPrice += expense.InvoiceInfo.Price;
                        added = true;
                        break;
                    }
                }
                if (added == false)
                {
                    expenseTypeTotalSpendsList.Add(new ExpenseTypeTotalSpend
                    {
                       
                        TotalPrice = expense.InvoiceInfo.Price,
                        ExpenseType = expense.ExpenseType
                    });
                }
            }
            return expenseTypeTotalSpendsList;

        }
    }

    public class EmployeeTotalSpend
    {
        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class ExpenseTypeTotalSpend
    {
        public string ExpenseType { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
