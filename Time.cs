using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4_Lamaev
{
    public class Time 
    {
        public int hour;
        public int minute;
        public int second;
        

        //public Time(int hours, int minutes, int seconds)
        //{
        //    hour = hours;
        //    minute = minutes;
        //    second = seconds;
        //}

        public void Read()
        {
            Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"часы:{hour} минуты: {minute} секунды: {second}");
        }
    }

        
    }
    

