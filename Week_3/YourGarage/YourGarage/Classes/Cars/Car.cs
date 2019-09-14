using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Classes
{
    class Car : Vehicle
    {
        public Car()
        {
            PassengerOcc = 5;
            FuelCap = 20;
            TopSpeed = 120;
        }

        public override void Drive(int distance)
        {
            OnRoad = true;
            base.Drive(distance);
        }
    }
}
