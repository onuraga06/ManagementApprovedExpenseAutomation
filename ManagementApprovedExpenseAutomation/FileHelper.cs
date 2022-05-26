
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApprovedExpenseAutomation
{
    public static class FileHelper
    {
        //Uygulamanın Calıstıgı Klasore gıt ve dosya yolu olustur yaz
        private static string _userFilePatch = Application.StartupPath + "\\users.json";//kullanıcıları tuttugumuz yer
        private static string _expenseTypePatch= Application.StartupPath + "\\expensetype.json";//Masraf tıplerını tuttugumuz yer
        private static string _expensePatch = Application.StartupPath + "\\expense.json";//Masrafların tutuldugu yer



        public static void WriteFileUsers(List<Users> users)
        {
            
            //Kullanıcı Listesini Serıalze et ve ayarları GetJsonFıleOptıons dan al
            string json=   JsonSerializer.Serialize<List<Users>>(users,GetJsonFileOptions()); //gonderdıgı dosyayı burada kulllan
            File.WriteAllText(_userFilePatch, json);//Geln Dosyayı yazdır.

        }
        public static List<Users> ReadFileUsers()
        {
            if (File.Exists(_userFilePatch))///Dosya varsa 
                //Okuma İşlemini de gelen dosyayı Deserılaze et gonder.
            {
                string json = File.ReadAllText(_userFilePatch);
                return   JsonSerializer.Deserialize<List<Users>>(json, GetJsonFileOptions());//json gonder ve kurallarına gore gonder
            }

            return new List<Users>();
        }
        public static void WriteFileExpenseType(List<string> masrafType)
        {            
            string json = JsonSerializer.Serialize<List<string>>(masrafType, GetJsonFileOptions()); 
            File.WriteAllText(_expenseTypePatch, json);
        }
        public static List<string> ReadFileExpenseType()
        {
            if (File.Exists(_expenseTypePatch))
            {
                string json = File.ReadAllText(_expenseTypePatch);
                return JsonSerializer.Deserialize<List<string>>(json, GetJsonFileOptions());
            }

            return new List<string>();
        }
        public static void WriteFileExpense(List<Expense> expense)
        {

            //Kullanıcı Listesini Serıalze et ve ayarları GetJsonFıleOptıons dan al
            string json = JsonSerializer.Serialize<List<Expense>>(expense, GetJsonFileOptions()); //gonderdıgı dosyayı burada kulllan
            File.WriteAllText(_expensePatch, json);//Geln Dosyayı yazdır.

        }
        public static List<Expense> ReadFileExpense()
        {
            if (File.Exists(_expensePatch))

            {
                string json = File.ReadAllText(_expensePatch);
                return JsonSerializer.Deserialize<List<Expense>>(json, GetJsonFileOptions());

              
            }
            return new List<Expense>();
        }



        private static JsonSerializerOptions GetJsonFileOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,//Buyuk Kucuk Harflere duyarısz ol
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,//kucuk harf yap json dosyalarına 
                WriteIndented = true,//Bosluluk yaz okunabılır olması
            };
            return options;//Dosyayı gonder
        }

        
    }
}
