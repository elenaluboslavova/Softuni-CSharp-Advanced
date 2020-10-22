using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        public HeroRepository()
        {
            this.Data = new List<Hero>();
        }

        public List<Hero> Data { get; set; }
        public int Count
        {
            get
            {
                return Data.Count;
            }
        }

        public void Add(Hero hero)
        {
            Data.Add(hero);
        }

        public void Remove(string name)
        {
            Data = Data.Where(x => x.Name != name).Select(y => y).ToList();
        }

        public Hero GetHeroWithHighestStrength()
        {
            int maxStrength = int.MinValue;
            Hero maxHero = null;
            foreach (var hero in Data)
            {
                if (hero.Item.Strength > maxStrength)
                {
                    maxStrength = hero.Item.Strength;
                    maxHero = hero;
                }
            }
            return maxHero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            int maxAbility = int.MinValue;
            Hero maxHero = null;
            foreach (var hero in Data)
            {
                if (hero.Item.Ability > maxAbility)
                {
                    maxAbility = hero.Item.Ability;
                    maxHero = hero;
                }
            }
            return maxHero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int maxIntelligence = int.MinValue;
            Hero maxHero = null;
            foreach (var hero in Data)
            {
                if (hero.Item.Intelligence > maxIntelligence)
                {
                    maxIntelligence = hero.Item.Intelligence;
                    maxHero = hero;
                }
            }
            return maxHero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hero in Data)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString();
        }
    }
}
