namespace CA_SRP_VALIDATE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Message.Greeting();

            User user = UserData.GetUserInfo();

            AuthenticationStatus status = AuthenticationManager.AuthenticateUser(user);

            switch(status)
            {
                case AuthenticationStatus.EmptyUserName:
                    Message.EmptyUserName();
                    Console.Read();
                    return;
                case AuthenticationStatus.EmptyPassword:
                    Message.EmptyPassword();
                    Console.Read();
                    return;
                case AuthenticationStatus.UserNotFound:
                    Message.UserNotFound();
                    Console.Read();
                    return;
                case AuthenticationStatus.WrongUserOrPassword:
                    Message.WrongUserOrPassword();
                    Console.Read();
                    return;
                case AuthenticationStatus.Error:
                    Message.Error();
                    Console.Read();
                    return;
            }

            Message.GreetUser(user);
        }
    }
}
