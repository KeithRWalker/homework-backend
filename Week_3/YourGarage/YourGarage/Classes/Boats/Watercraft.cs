using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Classes
{
    class Watercraft : Vehicle
    {
        public Watercraft(string color)
        {
            Color = color;
            TopSpeed = 50;
            FuelCap = 50;
            PassengerOcc = 2;
        }

        public void Dock()
        {
            if (FuelCap > 0)
            {
                InWater = false;
            }
        }

        public override void Drive(int distance)
        {
            InAir = false;
            OnRoad = false;
            InWater = true;
            base.Drive(distance);
        }

        public override void Refuel()
        {
            if (InWater == false)
            {
                base.Refuel();
            }
        }
    }
}
