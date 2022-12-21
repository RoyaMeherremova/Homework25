using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.Controllers
{
    internal class AccountController
    {
        public void Login()
        {
            IAccountService accountService = new AccountService();
            Console.WriteLine("Username daxil edin:");
            string username = Console.ReadLine();
            Console.WriteLine("Password daxil edin");
            string password = Console.ReadLine();

            accountService.Login(username, password);
        }
    }
}
