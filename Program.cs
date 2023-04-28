using PZ_4_Lamaev;
using System;
 using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            Thread currentThread = Thread.CurrentThread;
            Time time1 = new Time();
            Console.WriteLine("Введите часы");
            time1.hour = Convert.ToInt32(Console.ReadLine());
            currentThread.Name = time1.hour.ToString();
            Console.WriteLine($"Имя потока: {time1}");
            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
            Console.WriteLine("Введите минуты");
            time1.minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            time1.second = Convert.ToInt32(Console.ReadLine());
            time1.Display();





        }
    }
}
