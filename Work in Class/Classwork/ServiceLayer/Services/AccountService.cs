using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public void Login(string username, string password)
        {

            if (username == "Roya123" && password == "roya123")
            {
                Console.WriteLine("Giris Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
        }
    }
}
