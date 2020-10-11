using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        private int strength;
        private int ability;
        private int intelligence;

        public Item(int strength, int ability, int intelligence)
        {
            this.Stength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Stength
        {
            get{ return this.strength; } 
            private set { this.strength = value; } 
        }

        public int Ability
        {
            get { return this.ability; }
            private set { this.ability = value; }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            private set { this.intelligence = value; }
        }

        public override string ToString()   
        {
            var sb = new StringBuilder();

            sb.AppendLine("Item:");
            sb.AppendLine($"  * Strength: {this.Stength}");
            sb.AppendLine($"  * Ability: {this.Ability}");
            sb.AppendLine($"  * Intelligence: {this.Intelligence}");

            return sb.ToString().Trim();
        }
    }
}
