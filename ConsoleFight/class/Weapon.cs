using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFight
{
    abstract class Weapon : Item 
    {
        public float Damage;
        protected Weapon(string name, int durability, Rarity rarity, float damage)
            : base(name, durability, rarity)
        {
            Damage = damage > 0 ? damage : 1;
        }

    }
}
