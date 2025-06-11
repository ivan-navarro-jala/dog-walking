using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.Controllers
{
    public class LoginController : ILoginController
    {
        public bool Login(string username, string password)
        {
            return username.ToLower() == "sa" && password == "$4";
        }
    }
}
