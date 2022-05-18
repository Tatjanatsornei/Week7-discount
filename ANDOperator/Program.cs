using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND - &&
            //true && => true - username && password => welcome
            //true && => false => False - username && password => acces denided
            //false && true => false - username && password => access denided
            //false && false => false - username && password 1234
            // контрольные данные : username admin, password 1234
            //Задание1. Дополнить приложение, чтобы дать пользователю только 3 попытки для входа в систему

            int tries = 0;
            while (tries != 3)
            {
                string username, password;
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welkome!");
                    break;
                }
                else
                {
                    Console.WriteLine("Access denided.");
                    tries++;
                    Console.WriteLine($"You have made {tries} attempt.");
                }
            }
            Console.WriteLine("Have a nice day!");
        }
        
    }
}
