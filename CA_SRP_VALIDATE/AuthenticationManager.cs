using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SRP_VALIDATE
{

    
    public class AuthenticationManager
    {
        private static List<User> validUsers = new List<User>()
            {
                new User
                {
                    UserName = "abilgili",
                    Password = "1234",
                },
                new User
                {
                    UserName = "fgunalp",
                    Password = "123",
                },
                new User
                {
                    UserName = "user1",
                    Password = "password",
                },

            };




        public static void AddValidUser(string username, string password)
        {
            validUsers.Add(new User
            {
                UserName=username,
                Password=password,
            });
        }

        public static AuthenticationStatus AuthenticateUser(User user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                return AuthenticationStatus.EmptyUserName;
            }
            else
            {
                bool userFound = false;

                foreach (User u in validUsers)
                {
                    if (u.UserName == user.UserName)
                    {
                        userFound = true;
                    }
                }

                if (!userFound)
                {
                    return AuthenticationStatus.UserNotFound;
                }
                else
                {

                    if (string.IsNullOrEmpty(user.Password))
                    {
                        return AuthenticationStatus.EmptyPassword;
                    }
                    else
                    {
                        bool userAuthenticated = false;

                        foreach (User u in validUsers)
                        {
                            if (u.UserName == user.UserName)
                            {
                                if (u.Password == user.Password)
                                {
                                    userAuthenticated = true;
                                }
                            }
                        }

                        if (!userAuthenticated)
                        {
                            return AuthenticationStatus.WrongUserOrPassword;
                        }
                        else
                        {
                            return AuthenticationStatus.Success;
                        }
                    }

                    
                }

            }

            return AuthenticationStatus.Error;
        }



    }
}
