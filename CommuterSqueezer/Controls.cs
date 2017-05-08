using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Controls
    {
       public static void SimControls() {
            Console.CursorVisible = false;
            int redo = 0;
            ConsoleKeyInfo KeyInfo;
          
            do
            {
                KeyInfo = Console.ReadKey(true);
              
               
            

            switch (KeyInfo.Key)
            {
                 case ConsoleKey.Enter:
                    Console.WriteLine("worked");
                        break;
                case ConsoleKey.D1:
                        Pump filler1 = new Pump();
                        if (filler1.pump1_state == false)
                        {
                            filler1.pump1_activate();
                        }

                    break;
                case ConsoleKey.D2:
                        Pump filler2 = new Pump();
                        if (filler2.pump2_state == false)
                        {
                            filler2.pump2_activate();
                        }
                        break;
                case ConsoleKey.D3:
                        Pump filler3 = new Pump();
                        if (filler3.pump3_state == false)
                        {
                            filler3.pump3_activate();
                        }
                        break;
                case ConsoleKey.D4:
                        Pump filler4 = new Pump();
                        if (filler4.pump4_state == false)
                        {
                            filler4.pump4_activate();
                        }
                        break;
                case ConsoleKey.D5:
                        Pump filler5 = new Pump();
                        if (filler5.pump5_state == false)
                        {
                            filler5.pump5_activate();
                        }
                        break;
                case ConsoleKey.D6:
                        Pump filler6 = new Pump();
                        if (filler6.pump6_state == false)
                        {
                            filler6.pump6_activate();
                        }
                        break;
                case ConsoleKey.D7:
                        Pump filler7 = new Pump();
                        if (filler7.pump7_state == false)
                        {
                            filler7.pump7_activate();
                        }
                        break;
                case ConsoleKey.D8:
                        Pump filler8 = new Pump();
                        if (filler8.pump8_state == false)
                        {
                            filler8.pump8_activate();
                        }
                        break;
                case ConsoleKey.D9:
                        Pump filler9 = new Pump();
                        if (filler9.pump9_state == false)
                        {
                            filler9.pump9_activate();
                        }
                        break;
                default:
                        
                        break;
            
            }
            } while (redo == 0);
            Console.ReadLine();
        }
    }
}
