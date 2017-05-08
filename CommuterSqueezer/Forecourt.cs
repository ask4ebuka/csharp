using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetrolStation
{
    class Forecourt
    {
        public static void displayPos()
        {
            string line = "****************************************************";
            Console.SetCursorPosition(0, 0);
            for (int i = 5; i < 30; i += 10)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(line);
            }
        }
    }
}
