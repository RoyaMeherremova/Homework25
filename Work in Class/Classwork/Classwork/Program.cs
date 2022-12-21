


using Classwork.Controllers;
using Classwork.Helpers;
using Classwork.Models;

CalculateController calculateController = new();

calculateController.Calculate();
AccountController accountController = new AccountController();
accountController.Login();


Console.WriteLine(Car.Speed);

Car.Speed = 100;
Car car = new Car();
Car car2 = new Car();
Car car3 = new Car();


Book book = new Book();
Book book2 = new Book();
Book book3 = new Book();
Book book4 = new Book();
Book book5 = new Book();
Book book6 = new Book();
Book book7 = new Book();


Console.WriteLine(Book.Count);


int num = 100;

num.GetNum();


string address = "Quba";

if (address.CheckDigitInString())
{
    Console.WriteLine("Reqem var");
}
else
{
    Console.WriteLine("Reqem yoxdur");
}


string address1 = "Xirdalan";


if (address.CheckString(@"\d"))
{
    Console.WriteLine("Reqem var");
}
else
{
    Console.WriteLine("Reqem yoxdur");
}


string address2 = "Baku";

Console.WriteLine(address.CheckString(@"\d"));
Console.WriteLine(address.CheckString(@"[A-Z]"));
