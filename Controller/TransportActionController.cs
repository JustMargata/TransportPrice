using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Model;
using TransportPrice.View;

namespace TransportPrice.Controller
{
    internal class TransportActionController
    {
        Display Display = new Display();
        Transport Transport;

        public TransportActionController()
        {
            Display.Input();
            Transport = new Transport(Display.Kilometers, Display.DayOrNight);
            Display.Price = Transport.CalculatePrice();
            Display.Output();
        }
    }
}
