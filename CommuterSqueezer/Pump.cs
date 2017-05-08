using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Pump
    {
        //Unleaded, Diesel and LPG
        //Score score = new Score();
        string type_of_fuel;
        public int total_pump = 0;
        List<string> tank = new List<string>(new string[] { "**1**", "**2**", "**3**", "**4**", "**5**", "**6**", "**7**", "**8**", "**9**" });
        List<string> tank_busy = new List<string>(new string[] { "--1--", "--2--", "--3--", "--4--", "--5--", "--6--", "--7--", "--8", "--9--" });
        public Boolean pump1_state = false;
        public Boolean pump2_state = false;
        public Boolean pump3_state = false;
        public Boolean pump4_state = false;
        public Boolean pump5_state = false;
        public Boolean pump6_state = false;
        public Boolean pump7_state = false;
        public Boolean pump8_state = false;
        public Boolean pump9_state = false;

        
       
        


        public  static void pump()
        {
            List<string> tank = new List<string>(new string[] { "**1**", "**2**", "**3**", "**4**", "**5**", "**6**", "**7**", "**8**", "**9**" });
           
            Console.Write(tank[0]);

            Console.SetCursorPosition(35, 6);
            Console.Write(tank[1]);

            Console.SetCursorPosition(55, 6);
            Console.Write(tank[2]);

            Console.SetCursorPosition(15, 16);
            Console.Write(tank[3]);

            Console.SetCursorPosition(35, 16);
            Console.Write(tank[4]);

            Console.SetCursorPosition(55, 16);
            Console.Write(tank[5]);

            Console.SetCursorPosition(15, 26);
            Console.Write(tank[6]);

            Console.SetCursorPosition(35, 26);
            Console.Write(tank[7]);

            Console.SetCursorPosition(55, 26);
            Console.Write(tank[8]);

        }

        public void pump1_activate()
        { 
         pump1_state = true;
         Console.SetCursorPosition(15, 6);
       //  Console.ForegroundColor = ConsoleColor.Red;
         Console.Write(tank_busy[0]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000,19000);
            Score.pump1_time = t_fueltime;
            tc.Play(tc.Pump1_avialable,t_fueltime,t_fueltime);
           
        }

        public void pump2_activate()
        {
            pump2_state = true;
            Console.SetCursorPosition(35, 6);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[1]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump2_time = t_fueltime;
            tc.Play(tc.Pump2_avialable, t_fueltime, t_fueltime);
        }

        public void pump3_activate()
        {
            
            pump3_state = true;
            Console.SetCursorPosition(55, 6);
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[2]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump3_time = t_fueltime;
            tc.Play(tc.Pump3_avialable, t_fueltime, t_fueltime);
        }
        public void pump4_activate()
        {
            pump4_state = true;
            Console.SetCursorPosition(15, 16);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[3]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump4_time = t_fueltime;
            tc.Play(tc.Pump4_avialable, t_fueltime, t_fueltime);
        }

        public void pump5_activate()
        {
            pump5_state = true;
            Console.SetCursorPosition(35, 16);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[4]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump5_time = t_fueltime;
            tc.Play(tc.Pump5_avialable, t_fueltime, t_fueltime);
        }
        public void pump6_activate()
        {
            pump6_state = true;
            Console.SetCursorPosition(55, 16);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[5]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump6_time = t_fueltime;
            tc.Play(tc.Pump6_avialable, t_fueltime, t_fueltime);
        }

        public void pump7_activate()
        {
            pump7_state = true;
            Console.SetCursorPosition(15, 26);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[6]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump7_time = t_fueltime;
            tc.Play(tc.Pump7_avialable, t_fueltime, t_fueltime);
        }

        public void pump8_activate()
        {
            pump8_state = true;
            Console.SetCursorPosition(35, 26);
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[7]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump8_time = t_fueltime;
            tc.Play(tc.Pump8_avialable, t_fueltime, t_fueltime);
            

        }

        public void pump9_activate()
        {
            pump9_state = true;
            Console.SetCursorPosition(55, 26);
          //  Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tank_busy[8]);
            TimerCounter tc = new TimerCounter();
            Random fueltime = new Random();
            int t_fueltime = fueltime.Next(17000, 19000);
            Score.pump9_time = t_fueltime;
            tc.Play(tc.Pump9_avialable, t_fueltime, t_fueltime);
        }

        public void pump1_deactivate()
        {
            pump1_state = false;
            Console.SetCursorPosition(15, 6);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[0]);
           // score.pump1_serviced = score.pump1_serviced + 1;
            
        }

        public void pump2_deactivate()
        {
            pump2_state = false;
            Console.SetCursorPosition(35, 6);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[1]);
           // score.pump2_serviced = score.pump2_serviced + 1;
        }

        public void pump3_deactivate()
        {
            pump3_state = false;
            Console.SetCursorPosition(55, 6);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[2]);
            //score.pump3_serviced = score.pump3_serviced + 1;
        }

        public void pump4_deactivate()
        {
            pump4_state = false;
            Console.SetCursorPosition(15, 16);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[3]);
          //  score.pump4_serviced = score.pump4_serviced + 1;
        }

        public void pump5_deactivate()
        {
            pump5_state = false;
            Console.SetCursorPosition(35, 16);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[4]);
           // score.pump5_serviced = score.pump5_serviced + 1;
        }

        public void pump6_deactivate()
        {
            pump6_state = false;
            Console.SetCursorPosition(55, 16);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[5]);
         //   score.pump6_serviced = score.pump6_serviced + 1;
        }

        public void pump7_deactivate()
        {
            pump7_state = false;
            Console.SetCursorPosition(15, 26);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[6]);
          //  score.pump7_serviced = score.pump7_serviced + 1;
        }

        public void pump8_deactivate()
        {
            pump8_state = false;
            Console.SetCursorPosition(35, 26);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[7]);
           // score.pump8_serviced = score.pump8_serviced + 1;
        }

        public void pump9_deactivate()
        {
            pump9_state = false;
            Console.SetCursorPosition(55, 26);
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(tank[8]);
            //score.pump9_serviced = score.pump9_serviced + 1;
        }
    }
}
