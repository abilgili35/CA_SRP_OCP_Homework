using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SRP_VALIDATE
{
    public enum AuthenticationStatus
    {
        UserNotFound,
        WrongUserOrPassword,
        EmptyUserName,
        EmptyPassword,
        Error,
        Success,
    }
}
