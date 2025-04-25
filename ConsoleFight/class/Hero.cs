using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleFight
{
    class Hero
    {
        public string Name;
        private float _health;
        private int _level = 1;
        private int _experience = 0;
        private Weapon? _weapon;
        private Armor? _armor;

        public Hero(string name, float health, int level = 1, int experience = 0)
        {
            Name = !string.IsNullOrEmpty(name) ? name : "Безымянный герой";
            _health = health > 0 ? health : 100;
            _level = level > 0 ? level : 1;
            _experience = experience;
            _weapon = null; 
            _armor = null; 
        }

        public bool IsAlive()
        {
            return _health > 0;
        }
        public void Attack(Hero Enemu)
        {
            int DeltaDamage;
            if (_weapon.IsBreak == true)
            {
                DeltaDamage = 0;
            }
            else
            {
                if (this._weapon is Bow bow)
                {
                    bow.ShootArrow();
                }
                this._weapon.Break();
                DeltaDamage = (int)Math.Max(0, this._weapon.Damage - (Enemu._armor.Defense / 2));

            }

            Enemu.TakeDamage(DeltaDamage);
        }

        public void TakeDamage(float Damage) 
        {
            _health -= Damage;

            if (_health <= 0)
            {
                _health = 0;
                Console.WriteLine($"{Name} погибает...");
            }
            this._armor.Break();
        }


        public void EquipWeapon(Weapon weapon)
        {
            if (_weapon != null)
            {
                Console.WriteLine($"у тебя есть оружие {this._weapon.Name})");
            }
            else
            {
                this._weapon = weapon;
                Console.WriteLine($"у тебя теперь есть оружие {this._weapon.Name})");
            }

        }

        public void EquipArmor(Armor armor)
        {
            if (_armor != null)
            {
                Console.WriteLine("у тебя есть броня");
            }
            else
            {
                this._armor = armor;
                Console.WriteLine($"у тебя теперь есть броня {this._armor.Name}");
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"{Name} (Ур. {_level})");
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Оружие: {_weapon?.Name ?? "Нет"}");
            Console.WriteLine($"Броня: {_armor?.Name ?? "Нет"}");
            Console.WriteLine($"прочность оружия ");
            _weapon.status();
        }

    }
}
