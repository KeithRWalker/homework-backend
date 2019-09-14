using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Classes
{
    class Aircraft : Vehicle
    {
        public Aircraft()
        {
            TopSpeed = 100;
            FuelCap = 1000;
        }

        public void Land()
        {
            if (FuelCap > 0)
            {
                InAir = false;
            }
            else
            {
                Crash();
            }
        }

        public override void Drive(int distance)
        {
            base.Drive(distance);
            TakeOff(distance);
        }

        public override void Refuel()
        {
            if (InAir == false)
            {
                base.Refuel();
            }
        }

        public void Crash()
        {
            PassengerOcc = 0;
            Color = "Not Pretty";
            TopSpeed = 0;
            FuelCap = 0;
            Console.WriteLine("You Dead");
        }

        public void TakeOff(int dis)
        {
            TopSpeed = 500;
            InAir = true;
            Fly(dis);
        }

        public void Fly(int dis)
        {
            base.Drive(dis);
        }
    }
}
