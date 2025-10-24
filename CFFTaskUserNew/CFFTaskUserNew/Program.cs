using System;
using CFFTaskUserNew;

namespace CFFTaskUserNew
{
    class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            user.SetName();
            user.SetPassword();
            user.SetEmail();
            Admin admin = new Admin(user.Name,user.Password,user.Email);
            admin.PrintAll();
            Console.WriteLine("Admin Melumatlari.");

        }
    }
}