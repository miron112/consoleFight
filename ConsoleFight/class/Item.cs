using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFight
{
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare, 
        Epic,    
        Legendary  
    }
    abstract class Item
    {
        public string Name { get; set; }
        protected int _durability;
        public Rarity ItemRarity;
        public bool IsBreak = false;

        protected Item(string name, int durability, Rarity rarity)
        {
            Name = !string.IsNullOrEmpty(name) ? name : "Безымянный предмет";
            _durability = durability > 0 ? durability : 1;
            ItemRarity = rarity;
        }
        public virtual void Break()
        {
            _durability --;
            if ( _durability <= 0 )
            {
                Console.WriteLine($"{Name} сломалась!");
                IsBreak = true;
            }
        }
        public virtual void status()
        {
            Console.WriteLine(_durability);
        }
    }
}
