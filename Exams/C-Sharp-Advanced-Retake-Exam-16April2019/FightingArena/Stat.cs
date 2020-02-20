namespace FightingArena
{
    public class Stat
    {
        private int strength;
        private int flexibility;
        private int agility;
        private int skils;
        private int intelliegence;

        public Stat(int strength, int flexibility, int agility, int skills, int intelligence)
        {
            this.Strength = strength;
            this.Flexibility = flexibility;
            this.Agility = agility;
            this.Skills = skills;
            this.Intelligence = intelligence;
        }


        public int Strength { get { return this.strength; } set { this.strength = value; } }

        public int Flexibility { get { return this.flexibility; } set { this.flexibility = value; } }

        public int Agility { get { return this.agility; } set { this.agility = value; } }

        public int Skills { get { return this.skils; } set { this.skils = value; } }

        public int Intelligence { get { return this.intelliegence; } set { this.intelliegence = value; } }


        public int StatPowerCalculator()
        {
            int sum = this.Strength + this.Flexibility + this.Agility + this.Skills + this.Intelligence;

            return sum;
        }
    }
}
