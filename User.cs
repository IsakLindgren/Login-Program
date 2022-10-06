using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Program
{
    internal class User
    {

        public static string Name;
        public static string Password;

        public User(string name, string password)
        {

            Name = name;
            Password = password;

        }

        public static void List()
        {
            Console.WriteLine(Name);
        }

    }
}
