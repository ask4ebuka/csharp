using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    public class Score
    {
        public double litre =0;
        public static double commision = 0.01;
        public static double cost_per_litre = 3.0;
        public double default_litre = 30;
        public double cost_of_litres=0;

        public const double fuel_unleaded_price = 1.0;
        public const double fuel_diesel_price = 0.75;
        public const double fuel_LGP_price = 0.80;
        public double amount_of_money { get; set; }
        public double commission { get; set; }
        public double total_fuel { get; set; }
        public double pump1_litres { get; set;}
        public double pump2_litres { get; set; }
        public double pump3_litres { get; set; }
        public double pump4_litres { get; set; }
        public double pump5_litres { get; set; }
        public double pump6_litres { get; set; }
        public double pump7_litres { get; set; }
        public double pump8_litres { get; set; }
        public double pump9_litres { get; set; }
        public static double pump1_time { get; set; }
        public static double pump2_time { get; set; }
        public static double pump3_time { get; set; }
        public static double pump4_time { get; set; }
        public static double pump5_time { get; set; }
        public static double pump6_time { get; set; }
        public static double pump7_time { get; set; }
        public static double pump8_time { get; set; }
        public static double pump9_time { get; set; }
        public int number_of_vehicles_serviced { get; set; }
        public int pump1_serviced { get; set; }
        public int pump2_serviced { get; set; }
        public int pump3_serviced { get; set; }
        public int pump4_serviced { get; set; }
        public int pump5_serviced { get; set; }
        public int pump6_serviced { get; set; }
        public int pump7_serviced { get; set; }
        public int pump8_serviced { get; set; }
        public int pump9_serviced { get; set; }
        public List<String> vehicle_type = new List<string>();
        public List<double> Number_Litres = new List<double>();
        public List<int> pump_number = new List<int>();
        public List<String> fuel_type = new List<string>();
        public List<double> amount_made = new List<double>();
        public double total_litres { get; set; }

        public void litre_calaculation()
        {
            cost_of_litres = cost_per_litre * default_litre;
        }

        
        

    }
}
