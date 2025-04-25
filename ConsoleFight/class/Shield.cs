using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFight
{
    class Shield : Armor, IArmor
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
