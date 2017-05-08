using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PetrolStation
{
    class Program
    {
        static void Background()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

      
        static void WindowBorder()
        {
            Console.Title = "Petrol station";
            Console.SetWindowSize(120, 40);
            Console.SetBufferSize(120, 40);
        }
                      
        static void Main(string[] args)
        {
           
            WindowBorder();
            Background();
            
            TimerCounter tc2 = new TimerCounter();
            tc2.Play(tc2.Car_available, 0, 5000);
            tc2.Play(tc2.car_stop, 180000, 180000);

            Forecourt.displayPos();
            
          
            Controls.SimControls();           
        }
    }
}