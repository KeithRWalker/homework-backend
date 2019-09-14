using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace YourGarage.Classes.Cars
{
    class SUV : Car
    {
        public SUV(string color)
        {
            Color = color;
            PassengerOcc = 8;
            FuelCap = 35;
            TopSpeed = 130;
        }
    }
}
