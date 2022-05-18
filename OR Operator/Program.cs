using System;

namespace OR_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //OR - || - "или"
            //1.true || true => true
            //2.true || false => true
            //3. false || true => true
            //4. false || false => false

            // контрольные данные : username admin, password "1234"
            // Задание3. Дополнить приложение, чтобы дать пользователю только 3 попытки для входа в  

            int tries = 0;
            while (tries != 3)
            {
                string username, password;
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                if (username != "admin" || password != "1234")
                {
                    Console.WriteLine("Acces denided.");
                    tries++;
                    Console.WriteLine($"You have made {tries} attempts");
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}

