namespace StreetRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Race
    {
        private List<Car> participants;
        private string name;
        private string type;
        private int laps;
        private int capacity;
        private int maxHorsePower;


        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.participants = new List<Car>();
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
        }


        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public string Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }
        public int Laps
        {
            get { return this.laps; }
            private set { this.laps = value; }
        }
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }
        public int MaxHorsePower
        {
            get { return this.maxHorsePower; }
            private set { this.maxHorsePower = value; }
        }
        public IReadOnlyCollection<Car> Participants
        {
            get { return this.participants; }
        }
        public int Count
        {
            get { return this.Participants.Count; }
        }


        public void Add(Car car)
        {
            if (!this.participants.Contains(car) && this.Count < this.Capacity && car.HorsePower <= this.MaxHorsePower)
            {
                this.participants.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            return CarChecker(licensePlate);
        }
        public Car FindeParticipant(string licensePlate)
        {
            if (CarChecker(licensePlate))
            {
                return this.participants.Find(c => c.LicensePlate.Equals(licensePlate));
            }

            return null;
        }
        public Car GetMostPowerfulCar()
        {
            if (this.Count == 0)
            {
                return null;
            }

            var maxPower = 0;

            foreach (var item in this.participants)
            {
                if (item.HorsePower > maxPower)
                {
                    maxPower = item.HorsePower;
                }
            }

            return this.participants.Find(c => c.HorsePower.Equals(maxPower));
        }


        private bool CarChecker(string licensePlate)
        {
            foreach (var item in this.participants)
            {
                if (item.LicensePlate.Equals(licensePlate))
                {
                    return true;
                }
            }

            return false;
        }
        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");

            this.participants.ForEach(c => sb.AppendLine(c.ToString().Trim()));

            return sb.ToString().Trim();

        }
    }
}
