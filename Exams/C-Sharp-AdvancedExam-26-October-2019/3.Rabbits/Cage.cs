namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Cage
    {
        private List<Rabbit> data;
        private string name;
        private int capacity;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>(capacity);
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public int Count
        {
            get { return this.data.Count; }
        }

        public void Add(Rabbit rabbit)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            if (!EmptyCageChecker(this.data))
            {
                return this.data
                    .Remove(this.data.Find(rab => rab.Name.Equals(name)));
            }
            else
            {
                return default;
            }
        }

        public void RemoveSpecies(string species)
        {
            if (!EmptyCageChecker(this.data))
            {
                this.data
                .RemoveAll(n => n.Species.Equals(species));
            }
        }

        public Rabbit SellRabbit(string name)
        {
            if (!EmptyCageChecker(this.data))
            {
                this.data
                .Find(rab => rab.Name.Equals(name))
                .Available = false;

                return this.data
                    .Find(rab => rab.Name.Equals(name));
            }
            else
            {
                return default;
            }
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            if (!EmptyCageChecker(this.data))
            {
                this.data
                .FindAll(rab => rab.Species.Equals(species))
                .Select(rab => rab.Available = false)
                .ToList();

                return this.data
                    .Where(rab => rab.Species.Equals(species))
                    .ToArray();
            }
            else
            {
                return default;
            }
        }

        public string Report()
        {
            if (!EmptyCageChecker(this.data))
            {
                string output = $"Rabbits available at {this.Name}:";

                foreach (var item in this.data)
                {
                    if (item.Available == true)
                    {
                        output += $"\n{item}";
                    }
                }

                return output;
            }
            else
            {
                return default;
            }
        }

        public bool EmptyCageChecker(List<Rabbit> data)
        {
            if (data.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}