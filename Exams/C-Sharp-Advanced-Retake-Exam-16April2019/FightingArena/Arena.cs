namespace FightingArena
{
    using System.Collections.Generic;

    public class Arena
    {
        private List<Gladiator> gladiators;
        private string name;

        public Arena(string name)
        {
            gladiators = new List<Gladiator>();
            this.Name = name;
        }


        public string Name { get { return this.name; } set { this.name = value; } }

        public int Count { get { return this.gladiators.Count; } }


        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            gladiators.Remove(gladiators.Find(nam => nam.Name.Equals(name)));
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            string typeComparer = "StatPower";
            var sorted = this.gladiators;

            IComparer<Gladiator> comparer = new GladiatorComparer(typeComparer);
            sorted.Sort(comparer);

            return sorted[0];
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            string typeComparer = "WeaponPower";
            var sorted = this.gladiators;

            IComparer<Gladiator> comparer = new GladiatorComparer(typeComparer);
            sorted.Sort(comparer);

            return sorted[0];
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            string typeComparer = "TotalPower";
            var sorted = this.gladiators;

            IComparer<Gladiator> comparer = new GladiatorComparer(typeComparer);
            sorted.Sort(comparer);

            return sorted[0];
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }

        public class GladiatorComparer : IComparer<Gladiator>
        {
            private string typeComparer;

            public GladiatorComparer(string typeComparer)
            {
                this.typeComparer = typeComparer;
            }


            public int Compare(Gladiator x, Gladiator y)
            {
                if (typeComparer == "StatPower")
                {
                    return y.GetStatPower().CompareTo(x.GetStatPower());
                }
                else if (typeComparer == "WeaponPower")
                {
                    return y.GetWeaponPower().CompareTo(x.GetWeaponPower());
                }
                else if (typeComparer == "TotalPower")
                {
                    return y.GetTotalPower().CompareTo(x.GetTotalPower());
                }
                return default;
            }
        }
    }
}
