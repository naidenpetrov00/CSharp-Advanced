namespace StreetRacing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private string licensePlate;
        private int horsePower;
        private double weight;

        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            this.Make = make;
            this.Model = model;
            this.LicensePlate = licensePlate;
            this.HorsePower = horsePower;
            this.Weight = weight;
        }

        public string Make
        {
            get { return this.make; }
            private set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string LicensePlate
        {
            get { return this.licensePlate; }
            private set { this.licensePlate = value; }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            private set { this.horsePower = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            private set { this.weight = value; }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"License Plate: {this.LicensePlate}");
            sb.AppendLine($"Horse Power: {this.HorsePower}");
            sb.AppendLine($"Weight: {this.Weight}");

            return sb.ToString().Trim();
        }
    }
}
