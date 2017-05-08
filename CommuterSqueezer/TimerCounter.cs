using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PetrolStation
{
    class TimerCounter
    {
        Score score_counter = new Score();
       
        List<Timer> Timerlist = new List<Timer>();
        List<String> line2 = new List<string>(5);
        List<Timer> Timerlist2 = new List<Timer>();
        Random random_vehicle = new Random();
        int ct = 0;
        int ran = 0;
        bool car_enter = true;
        string car_type;
        string fuel_type;
        double total_money = 0;
        int number_of_cars_left = 0;
        public List<Timer> pump1_timer = new List<Timer>();
        public List<Timer> pump2_timer = new List<Timer>();
        public List<Timer> pump3_timer = new List<Timer>();
        public List<Timer> pump4_timer = new List<Timer>();
        public List<Timer> pump5_timer = new List<Timer>();
        public List<Timer> pump6_timer = new List<Timer>();
        public List<Timer> pump7_timer = new List<Timer>();
        public List<Timer> pump8_timer = new List<Timer>();
        public List<Timer> pump9_timer = new List<Timer>();

        public void Play(TimerCallback timerMethod, int duetime, int period)
        {

            Timer t = new Timer(timerMethod, null, duetime, period);
            Timerlist.Add(t);
        }

        public void Play (TimerCallback timerMethod)
        {

            Timer t = new Timer(timerMethod, null, 10000, 10000);
        }
        //public void Play(TimerCallback timerMethod,string a)
        //{

        //    Timer t = new Timer(timerMethod, null, 18000, 18000);
        //}
        public void GameOver(object state)
        {
            Console.Clear();
            String end = "Game Over";
            Console.SetCursorPosition(58, 18);
            Console.Write(end);
        }

       
        public void Car_available(object state)
        {

            // cr.car_add();
            try
            {
               // Console.Clear();

                string b = "0=0";
               // Console.SetCursorPosition(40, 20);
                //Console.WriteLine(ran);

                line2.Add(b);
                Console.SetCursorPosition(65, 15);
                foreach (var num in line2)
                {
                    Console.Write(" {0} ", String.Join(". ", num));
                }
                ct = ct + 1;
                Timer r = new Timer(Car_left, null, 1500, 1500);
                Timerlist2.Add(r);
                //  Play(Car_remove,3300,3300);
            }
            finally
            {
                foreach (Timer time in Timerlist)
                {
                    if (Timerlist.First() == time)
                    {
                        time.Change(random_vehicle.Next(1500, 2200), random_vehicle.Next(1500, 2200));

                    }

                }
            }
        }

        public void car_stop(object state)
        {
            score_counter.number_of_vehicles_serviced = score_counter.pump1_serviced + score_counter.pump2_serviced + score_counter.pump3_serviced + score_counter.pump4_serviced + score_counter.pump5_serviced + score_counter.pump6_serviced + score_counter.pump7_serviced + score_counter.pump8_serviced + score_counter.pump9_serviced;
            //score_counter.amount_of_money = 
            score_counter.commission = 0.01 * score_counter.number_of_vehicles_serviced;
            score_counter.total_litres = score_counter.pump1_litres + score_counter.pump2_litres+ score_counter.pump3_litres + score_counter.pump4_litres + score_counter.pump5_litres + score_counter.pump6_litres + score_counter.pump7_litres + score_counter.pump8_litres + score_counter.pump9_litres;
            foreach (Timer time in Timerlist)
            {
                time.Dispose();
                
            }
            foreach (double money in score_counter.amount_made)
                { total_money = total_money + money; }
            Console.Clear();
            Console.WriteLine("Total number of litres {0}",score_counter.total_litres);
            Console.WriteLine("Amount of money £{0}", total_money);
            Console.WriteLine("1% commission {0}", score_counter.commission);
            Console.WriteLine("Number of vehicles serviced {0}",score_counter.number_of_vehicles_serviced);
            Console.WriteLine(" Number of car that left {0}", number_of_cars_left);
            Console.WriteLine("Vehicle type, Number of litres, Pump Number ");
            for (int i =0; i >= score_counter.vehicle_type.Count(); i++)
            {
                Console.WriteLine("{0}   {1}   {2} ",score_counter.vehicle_type[i], score_counter.Number_Litres[i],score_counter.pump_number[i]);
            }

        }
        public void Car_left(object state)
        { 

            if (line2.Any())
            {
                line2.RemoveAt(0);
                number_of_cars_left = number_of_cars_left + 1;
                foreach (Timer time in Timerlist2)
                {
                    time.Dispose(); 
                }
                Console.Clear();
                Forecourt.displayPos();
                Pump.pump();
                if (line2.Any())
                {
                    Console.SetCursorPosition(65, 15);
                    foreach (var num in line2)
                    {
                        Console.Write(" {0} ", String.Join(". ", num));
                    }
                }
            }
        }
        public void Car_passed_through(object state)
        {

            if (line2.Any())
            {
                line2.RemoveAt(0);
                foreach (Timer time in Timerlist2)
                {
                    time.Dispose();
                }
                Console.Clear();
                Forecourt.displayPos();
                Pump.pump();
                if (line2.Any())
                {
                    Console.SetCursorPosition(65, 15);
                    foreach (var num in line2)
                    {
                        Console.Write(" {0} ", String.Join(". ", num));
                    }
                }
            }
        }
        public void Pump1_avialable(object state)
        {
            Pump pm = new Pump();
            Score litres = new Score();
            litres.litre_calaculation();
            pm.pump1_deactivate();
            score_counter.pump1_litres = score_counter.pump1_litres + (1.5 * Score.pump1_time);
            score_counter.pump1_serviced = score_counter.pump1_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1,3);
            if (fuel ==1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump1_time )); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump1_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump1_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(1);
            score_counter.Number_Litres.Add(1.5 * Score.pump1_time);
            
        }
        public void Pump2_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump2_deactivate();
            score_counter.pump2_litres = score_counter.pump2_litres + (1.5 * Score.pump2_time);
            score_counter.pump2_serviced = score_counter.pump2_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump2_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump2_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump2_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(2);
            score_counter.Number_Litres.Add(1.5 * Score.pump2_time);


        }
        public void Pump3_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump3_deactivate();
            score_counter.pump3_litres = score_counter.pump3_litres + (1.5 * Score.pump3_time);
            score_counter.pump3_serviced = score_counter.pump3_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump3_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump3_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump3_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(3);
            score_counter.Number_Litres.Add(1.5 * Score.pump3_time);


        }
        public void Pump4_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump4_deactivate();
            score_counter.pump4_litres = score_counter.pump4_litres + (1.5 * Score.pump4_time);
            score_counter.pump4_serviced = score_counter.pump4_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump4_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump4_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump4_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(4);
            score_counter.Number_Litres.Add(1.5 * Score.pump4_time);


        }
        public void Pump5_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump5_deactivate();
            score_counter.pump5_litres = score_counter.pump5_litres + (1.5 * Score.pump5_time);
            score_counter.pump5_serviced = score_counter.pump5_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump5_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump5_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump5_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(5);
            score_counter.Number_Litres.Add(1.5 * Score.pump5_time);

        }
        public void Pump6_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump6_deactivate();
            score_counter.pump6_litres = score_counter.pump6_litres + (1.5 * Score.pump6_time);
            score_counter.pump6_serviced = score_counter.pump6_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump6_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump6_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump6_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(6);
            score_counter.Number_Litres.Add(1.5 * Score.pump6_time);


        }
        public void Pump7_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump7_deactivate();
            score_counter.pump7_litres = score_counter.pump7_litres + (1.5 * Score.pump7_time);
            score_counter.pump7_serviced = score_counter.pump7_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump7_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump7_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump7_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(7);
            score_counter.Number_Litres.Add(1.5 * Score.pump7_time);


        }
        public void Pump8_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump8_deactivate();
            score_counter.pump8_litres = score_counter.pump8_litres + (1.5 * Score.pump8_time);
            score_counter.pump8_serviced = score_counter.pump8_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump8_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump8_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump8_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(8);
            score_counter.Number_Litres.Add(1.5 * Score.pump8_time);


        }
        public void Pump9_avialable(object state)
        {
            Pump pm = new Pump();
            pm.pump9_deactivate();
            score_counter.pump9_litres = score_counter.pump9_litres + (1.5 * Score.pump9_time);
            score_counter.pump9_serviced = score_counter.pump9_serviced + 1;

            Random car_gen = new Random();
            int car = car_gen.Next(1, 3);
            if (car == 1)
            { car_type = "car"; }
            else if (car == 2)
            { car_type = "van"; }
            else if (car == 3)
            { car_type = "HGV"; }

            Random fuel_gen = new Random();
            int fuel = fuel_gen.Next(1, 3);
            if (fuel == 1)
            { fuel_type = "unleaded"; }
            if (fuel == 2)
            { fuel_type = "diesel"; }
            if (fuel == 3)
            { fuel_type = "LPG"; }

            if (fuel_type == "unleaded")
            { score_counter.amount_made.Add(Score.fuel_unleaded_price * (1.5 * Score.pump9_time)); }
            if (fuel_type == "diesel")
            { score_counter.amount_made.Add(Score.fuel_diesel_price * (1.5 * Score.pump9_time)); }
            if (fuel_type == "LPG")
            { score_counter.amount_made.Add(Score.fuel_LGP_price * (1.5 * Score.pump9_time)); }

            score_counter.vehicle_type.Add(car_type);
            score_counter.fuel_type.Add(fuel_type);
            score_counter.pump_number.Add(9);
            score_counter.Number_Litres.Add(1.5 * Score.pump9_time);


        }

        public  void dispose_pump1_timer()
        {
             foreach (Timer time in pump1_timer )
                {
                    time.Dispose();
                }
        }

        public  void dispose_pump2_timer()
        {
            foreach (Timer time in pump2_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump3_timer()
        {
            foreach (Timer time in pump3_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump4_timer()
        {
            foreach (Timer time in pump4_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump5_timer()
        {
            foreach (Timer time in pump5_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump6_timer()
        {
            foreach (Timer time in pump6_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump7_timer()
        {
            foreach (Timer time in pump7_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump8_timer()
        {
            foreach (Timer time in pump8_timer)
            {
                time.Dispose();
            }
        }

        public void dispose_pump9_timer()
        {
            foreach (Timer time in pump9_timer)
            {
                time.Dispose();
            }
        }
    }

}
