using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApprovedExpenseAutomation
{
    public static class UserProcess
    {
       private static List<Users> _users = FileHelper.ReadFileUsers(); 
        public  static string GetUserFullName(Guid id)
        {
            foreach (Users item in _users)
            {
                if (item.ID  == id)
                {
                    return item.UserFullName;
                }
            }
            return "--";
        }
    }
}
