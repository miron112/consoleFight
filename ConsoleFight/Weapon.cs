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
    class Bow : Weapon
    {
        private int _arrowcount = 5;

        public Bow(string name, int durability, Rarity rarity, float damage)
    : base(name, durability, rarity, damage)
        {
        }

        public override void Break()
        {
            base.Break();
        }

        public void ShootArrow()
        {
            if (_arrowcount > 0)
            {
                _arrowcount--;
                Console.WriteLine($"Выпущена стрела! Осталось: {_arrowcount}");
            }
            else
            {
                Console.WriteLine("стрел нет)");
            }
        }

        public void AddArrow()
        {
            this._arrowcount++;
        }
    }
}
