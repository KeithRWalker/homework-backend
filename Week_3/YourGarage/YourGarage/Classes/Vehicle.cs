using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Classes
{
    abstract class Vehicle
    {
        public int PassengerOcc { get; set; }
        public int TopSpeed { get; set; }
        public string Color { get; set; }
        public bool IsMoving { get; protected set; }
        public bool InAir { get; protected set; }
        public bool InWater { get; protected set; }
        public bool OnRoad { get; protected set; }
        public int FuelCap { get; set; }

        public virtual void Drive(int distance)
        {
            if (FuelCap <= 0)
            {
                IsMoving = false;
            }
            else
            {
                FuelCap -= distance;
                IsMoving = true;
            }
        }

        public virtual void Brake()
        {
            IsMoving = false;
        }

        public virtual void Refuel()
        {
            FuelCap = 100;
        }
    }
}