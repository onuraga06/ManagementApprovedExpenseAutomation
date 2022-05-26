using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApprovedExpenseAutomation
{
    public static class EnumHelper
    {
        public static string GetEnumTypeName(UsersType userType)
        {
            string result=string.Empty;
         
            switch (userType)
            {
                case UsersType.admin:
                    result = "Sistem Yöneticisi";
                    break;
                case UsersType.manager:
                    result = "Yönetici";
                    break;
                case UsersType.purser:
                    result = "Muhasebeci";
                    break;
                case UsersType.employee:
                    result = "Personel";
                    break;
            }
            return result;
        }
    }
}
