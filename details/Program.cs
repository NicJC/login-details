using System;

namespace Login
{
    class Username_Password
    {
        public static void Main()
        {
            string username, password;
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            if (username == "Nic" && password == "apv45qgy")
            {
                Console.WriteLine("Access Granted.");
            }
            else if (username != "Nic" && password == "apv45qgy")
            {
                Console.WriteLine("The username is wrong.");
            }
            else if (username == "Nic" && password != "apv45qgy")
            {
                Console.WriteLine("The password is wrong.");
            }
            else
            {
                Console.WriteLine("Access Denied.");
            }
        }
    }
}
