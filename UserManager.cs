using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Program
{
    internal class UserManager
    {

        static List<User> users = new List<User>();

        public static void Add(User user)
        {
            users.Add(user);
        }

        public static void List()
        {
            foreach (var user in users)
            {
                User.List();
            }
        }

    }
}
