using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Model
{
    internal class Transport
    {
        private double taxiDayFee = 0.79;
        private double taxiNightFee = 0.9;
        private double taxiStartFee = 0.7;
        private double busFee = 0.09;
        private double trainFee = 0.06;

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
        public Transport()
        {

        }
        public Transport(int kilometers, string dayOrNight)
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
                    return (this.Kilometers * taxiDayFee) + taxiStartFee;
                }
                else
                {
                    return (this.Kilometers * taxiNightFee) + taxiStartFee;
                }
            }
            else if (this.Kilometers >= 20 && this.Kilometers < 100)
            {
                return this.Kilometers * busFee;
            }
            else
            {
                return this.Kilometers * trainFee;
            }

        }
    }
}
