using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3
{
    class Vehicle
    {
        protected int seats;
        protected int caryingCapacity;
        protected string color;
        protected double distanceTraveled;
        private float gearRatio;
        private float engineSize;
        private double movementSpeed;

        public int Seats
        {
            get { return this.seats; }
            set { this.seats = value; }
        }
        
        public int CarryingCapacity
        {
            get { return this.caryingCapacity; }
            set { this.caryingCapacity = value; }
        }   

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public float EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }
        public double MovementSpeed
        {
            get { return this.movementSpeed; }
            set { this.movementSpeed = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
        }
        public Vehicle()
        {
            //Default constructor
        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.caryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;
        }

        public void Move()
        {
            distanceTraveled += movementSpeed;

        }
        
    }
}
