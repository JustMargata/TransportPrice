using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Model
{
    internal class Transport
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
        public double TaxiDayFee { get; set; } = 0.79;
        public double TaxiNightFee { get; set; } = 0.9;
        public double TaxiStartFee { get; set; } = 0.7;
        public double BusFee { get; set; } = 0.09;
        public double TrainFee { get; set; } = 0.06;
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
                    return (this.Kilometers * TaxiDayFee) + TaxiStartFee;
                }
                else
                {
                    return (this.Kilometers * TaxiNightFee) + TaxiStartFee;
                }
            }
            else if (this.Kilometers >= 20 && this.Kilometers < 100)
            {
                return this.Kilometers * BusFee;
            }
            else
            {
                return this.Kilometers * TrainFee;
            }

        }
    }
}
