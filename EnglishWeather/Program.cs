using System;

namespace EnglishWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temp < 0 then Freezing cold
            //Temp 0-10 then Very Cold
            //Temp 10-20 then Cold
            //Temp 20-30 then Warm
            //Temp 30-35 then Hot
            //>= 35 then Boiling Hot
            //приложение позволяет пользователю ввести текущую температуру воздуха (по С)
            //приложение отвечает, как называется температура в данном диапазоне предложением на английском
            //Задание 3. Дописать код приложения до конца.

            int currentTemp;
            Console.WriteLine("Enter the temperature:");
            currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp < 0)
            {
                Console.WriteLine("Freezeng cold");
            }
            else if (currentTemp >= 0 && currentTemp <= 10)
            {
                Console.WriteLine("Very cold");
            }
            else if (currentTemp > 10 && currentTemp <= 20)
            {
                Console.WriteLine("Cold");
            }
            else if (currentTemp > 20 && currentTemp <= 30)
            {
                Console.WriteLine("Warm");
            }
            else if (currentTemp > 30 && currentTemp < 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Boiling Hot");
            }
            Console.WriteLine("Have a nice day!");
        }
        
    }
}
