using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает пользователя, на какую сумму он сделал покупку в магазине "Н"
            //усли сумма чека составила больше 10 евро, то пользователь получает  скидку на следующую покупку в размере 1 евро
            //если сумма чека составляе от 20 евро до 50 евро, то скидка на следующую покупку 5 евро
            //если сумма чека от 50 - 100 евро, то скидка на следующую покупку 10 евро
            //если сумма чека превышает 100 евро, то скидка на следующую покупку составляет 15 евро

            int currentSum;
            Console.WriteLine("Enter your check amount");
            currentSum = Convert.ToInt32(Console.ReadLine());

            if (currentSum >= 10 && currentSum <= 20)
            {
                Console.WriteLine("You have 1 euro discount on you next purhase");
            }
            else if (currentSum < 10)
            {
                Console.WriteLine("Buy from 10 euro to get discount");
            }
            else if (currentSum > 20 && currentSum <= 50)
            {
                Console.WriteLine("You have 5 euro discount on your next purchase");
            }
            else if (currentSum > 50 && currentSum <= 100)
            {
                Console.WriteLine("You have 10 euro discount on your next purchase");
            }
            else
            {
                Console.WriteLine("You have 15 euro discount on your next purchase");
            }
            Console.WriteLine("have a nice day!");
        }
    }
}
