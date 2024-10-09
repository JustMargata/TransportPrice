using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Model
{
    internal class Model
    {
        private int kilometers;

        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }
        private string dayOrNight;

        public string DayOrNight
        {
            get { return dayOrNight; }
            set { dayOrNight = value; }
        }

        public Model(int kilometers, string dayOrNight)
        {
            this.Kilometers = kilometers;
            this.DayOrNight = dayOrNight;
        }
        public double CalculatePrice()
        {
            if (this.Kilometers < 20)
            {
                if (this.DayOrNight == "day")
                {
                    return (this.Kilometers * 0.7) + 0.7;
                }
                else
                {
                    return (this.Kilometers * 0.9) + 0.7;
                }
            }
            else if (this.Kilometers >= 20 && this.Kilometers < 100)
            {
                return this.Kilometers * 0.09;
            }
            else
            {
                return this.Kilometers * 0.06;
            }

        }
    }
}
