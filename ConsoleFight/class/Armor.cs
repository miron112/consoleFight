using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFight
{
    abstract class Armor : Item
    {
        private int defense;

        protected Armor(string name, int durability, Rarity rarity, int defense)
    : base(name, durability, rarity)
        {
            Defense = defense > 0 ? defense : 1;
        }

        public int Defense { get => defense; set => defense = value; }
    }


}
