using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_29_10_2021
{
    internal class Start
    {
        public Start()
        
        {
            List<User> addedDataUserList= AddData();
            User inputUser = GetInput();
            CheckList(addedDataUserList, inputUser);
        }

        private void CheckList(List<User>fullList, User checkUser)
        {

            foreach(User user in fullList)
            {
                if (checkUser.Name==user.Name)
                {

                    Console.WriteLine("yes!!");
                    if (checkUser.Password == user.Password)
                    {
                        Console.WriteLine("ja ja ja ja ");

                    }
                    else Console.WriteLine("NO NO NO NO NO NO");
                }

            }

        }



        private List<User> AddData()
        {
            
            User user1 = new User() { Name="Hans",Password="abc123"};
            User user2 = new User() { Name="Per",Password="efg456"};
            User user3 = new User() { Name="Åge",Password="hij789"};
            List<User> userList = new List<User>() { user1, user2, user3 };
            return userList;
        }



         public User GetInput()
        {

            Console.Write("Login\nUsername:");
            string inputUsername=Console.ReadLine();

            Console.Write("Login\nPassword:");
            string inputPassword=Console.ReadLine();

            User bruger = new User();
            bruger.Name = inputUsername;
            bruger.Password = inputPassword;
            return bruger;
        }

        internal class User
        {

            public string Name { get; set; }
            public string Password { get; set; }

        }



    }
}
