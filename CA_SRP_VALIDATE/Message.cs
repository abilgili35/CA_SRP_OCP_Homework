using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SRP_VALIDATE
{
    public class Message
    {
        public static void Greeting()
        {
            Console.WriteLine("Uygulamaya hosgeldiniz.Giris yapmak icin kullanici bilgileriniz giriniz.");
        }

        public static void UserNotFound()
        {
            Console.WriteLine("Kullanici bulunamadi.");
        }

        public static void Error()
        {
            Console.WriteLine("Bir hata olustu.");
        }

        public static void WrongUserOrPassword()
        {
            Console.WriteLine("Yanlis kullanici adi veya sifre");
        }

        public static void EmptyUserName()
        {
            Console.WriteLine("Kullanici adi boş geçilemez!");
        }

        public static void EmptyPassword()
        {
            Console.WriteLine("Kullanici sifresi boş geçilemez!");
        }

        public static void GreetUser(User user)
        {
            Console.WriteLine($"Merhaba {user.UserName}.Uygulamaya hosgeldin.");
        }
    }
}
