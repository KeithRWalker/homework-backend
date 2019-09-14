using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Classes
{
    class ElectricCar : Car
    {
        public int BatteryCap { get; set; }
        public bool SelfDrive { get; set; }

        public ElectricCar(string color)
        {
            FuelCap = 0;
            BatteryCap = 100;
            PassengerOcc = 4;
            TopSpeed = 100;
            Color = color;
        }

        public override void Drive(int distance)
        {
            if (BatteryCap <= 0)
            {
                IsMoving = false;
            }
            else
            {
                BatteryCap -= distance;
                IsMoving = true;
                OnRoad = true;
            }
        }

        public override void Refuel()
        {
            BatteryCap = 100;
        }

        public void AutoPilot(int distance)
        {
            SelfDrive = true;
            Refuel();
            Drive(distance);
        }


    }
}
