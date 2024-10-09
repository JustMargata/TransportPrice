using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.View
{
    internal class Display
    {
        public int Kilometers { get; set; }
        public string DayOrNight { get; set; }
        public double Price { get; set; }
        public void Input()
        {
            this.Kilometers = int.Parse(Console.ReadLine());
            this.DayOrNight = Console.ReadLine();
        }
        public void Output() 
        {
            Console.WriteLine($"{this.Price:F2}");
        }
    }
}
