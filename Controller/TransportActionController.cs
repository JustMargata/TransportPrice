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
        Display displayche = new Display();
        Transport modelche = new Transport();

        public TransportActionController()
        {

        }

        public void Start()
        {
            displayche.Input();
            modelche.DayOrNight = displayche.DayOrNight;
            modelche.Kilometers = displayche.Kilometers;
            displayche.Price = modelche.CalculatePrice();
            displayche.Output();
        }
    }
}
