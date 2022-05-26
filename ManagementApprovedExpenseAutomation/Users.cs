using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApprovedExpenseAutomation
{
    public class Users
    {
        public Guid ID { get; set; }
        public string UserFullName { get; set; }
        public string UserLoginName { get; set; }
        public string UserPassword { get; set; }
        public UsersType Type { get; set; }//Kullanıcı Tıpını Belırlemek ıcın
        public Guid? ManagerID { get; set; }//Yonetıcı ıle bıreber ılıskısı var//

        public override string ToString()
        {
            return $"{UserFullName}-({UserLoginName})-({EnumHelper.GetEnumTypeName(Type)})";
        }
    }

    public enum UsersType
    {
        admin ,
        manager,
        purser,
        employee
    }
}
