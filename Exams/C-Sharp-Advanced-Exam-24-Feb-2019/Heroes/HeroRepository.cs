using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public IReadOnlyCollection<Hero> Data => (IReadOnlyCollection<Hero>)this.data;

        public int Count => Data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            var hero = this.data.Find(h => h.Name.Equals(name));
            this.data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var max = int.MinValue;
            Hero hero = null;

            foreach (var item in this.data)
            {
                if (item.Item.Stength > max)
                {
                    hero = item;
                    max = item.Item.Stength;
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var max = int.MinValue;
            Hero hero = null;

            foreach (var item in this.data)
            {
                if (item.Item.Ability > max)
                {
                    hero = item;
                    max = item.Item.Ability;
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var max = int.MinValue;
            Hero hero = null;

            foreach (var item in this.data)
            {
                if (item.Item.Intelligence > max)
                {
                    hero = item;
                    max = item.Item.Intelligence;
                }
            }

            return hero;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.data.ForEach(h => sb.AppendLine(h.ToString()));

            return sb.ToString().Trim();
        }
    }
}
