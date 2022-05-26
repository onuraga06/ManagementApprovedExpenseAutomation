using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApprovedExpenseAutomation
{
   public class Expense//Masraf
    {
        public Guid ID { get; set; }
        public string ExpenseType { get; set; }
        public string Description { get; set; }
        public Invoice InvoiceInfo { get; set; }//Fİş Bilgisi
        public ExpenseStatus Status { get; set; }//Masraf onaylama yonetıcı tarafından
        public Guid UsersID { get; set; }//Masrafın Sahıbı

    }
    public class Invoice//Fiş
    {
        public string Number { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }

      
    }
    public enum ExpenseStatus
    {
        OnayBekliyor,
        Onaylandı,
        Red,
        Odendi,

    }
}
