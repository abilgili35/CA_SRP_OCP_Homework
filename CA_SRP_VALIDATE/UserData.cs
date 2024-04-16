using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SRP_VALIDATE
{
    public class UserData
    {
        public static User GetUserInfo()
        {
            User user = new User();

            Console.WriteLine("Lütfen kullanici adini girin");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Lütfen kullanici sifresini girin");
            user.Password = Console.ReadLine();

            return user;
        }
    }
}
