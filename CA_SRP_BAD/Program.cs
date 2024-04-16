namespace CA_SRP_BAD 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> validUsers = new List<User>()
            {
                new User
                {
                    UserName = "abilgili",
                    Password = "password",
                },
                new User
                {
                    UserName = "fgunalp",
                    Password = "1234",
                },
                new User
                {
                    UserName = "user",
                    Password = "123",
                }
            };

            User user = new User();

            Console.WriteLine("Uygulamaya hosgeldiniz.Giris yapmak icin kullanici bilgileriniz giriniz.");

            Console.WriteLine("Lütfen kullanici adını girin");
            user.UserName = Console.ReadLine();

            if (string.IsNullOrEmpty(user.UserName))
            {
                Console.WriteLine("kullanici adi boş geçilemez!");
                return;
            }
            else
            {
                bool userFound = false;

                foreach(User u in validUsers)
                {
                    if(u.UserName == user.UserName)
                    {
                        userFound = true;
                    }
                }

                if (!userFound)
                {
                    Console.WriteLine("Kullanici bulunamadi.");
                    return;
                }
                else
                {
                    Console.WriteLine("Lütfen kullanici sifresini girin");
                    user.Password = Console.ReadLine();

                    if (string.IsNullOrEmpty(user.Password))
                    {
                        Console.WriteLine("Kullanici sifresi boş geçilemez!");
                        return;
                    }
                    else
                    {
                        bool userAuthenticated = false;

                        foreach (User u in validUsers)
                        {
                            if (u.UserName == user.UserName)
                            {
                                if(u.Password == user.Password)
                                {
                                    userAuthenticated = true;
                                }
                            }
                        }

                        if (!userAuthenticated)
                        {
                            Console.WriteLine("Yanlis kullanici adi veya sifre.");
                            return;
                        }
                    }
                }

            }

            

            Console.WriteLine("Kullanici bilgileri");
            Console.WriteLine($"Kullanici Adi: {user.UserName} Soyad: {user.Password}");
        }
    }
}
