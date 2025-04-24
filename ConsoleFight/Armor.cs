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

    class Shield : Armor
    {
        private int blockChance;

        public Shield(string name, int durability, Rarity rarity, int defense, int blockChance)
    : base(name, durability, rarity, defense)
        {
            BlockChance = blockChance >= 0 && blockChance <= 100 ? blockChance : 0;
        }

        public int BlockChance { get => blockChance; set => blockChance = value; }

        public override void Break()
        {
            base.Break();
        }
    }
}
