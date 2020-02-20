namespace FightingArena
{
    using System;

    public class Gladiator : IComparable<Gladiator>
    {
        private string name;
        private Stat stat;
        private Weapon weapon;

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }


        public string Name { get { return this.name; } set { this.name = value; } }

        public Stat Stat { get { return this.stat; } set { this.stat = value; } }

        public Weapon Weapon { get { return this.weapon; } set { this.weapon = value; } }


        public int GetTotalPower() => this.stat.StatPowerCalculator() + this.weapon.WeaponPowerCalculator();

        public int GetWeaponPower() => this.weapon.WeaponPowerCalculator();

        public int GetStatPower() => this.stat.StatPowerCalculator();

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalPower()}" +
                $"\n Weapon Power: {GetWeaponPower()}" +
                $"\n Stat Power: {GetStatPower()}";
        }


        public int CompareTo(Gladiator other)
        {
            return default;
        }
    }
}
