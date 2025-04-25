using System;

namespace ConsoleFight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём героев
            Hero warrior = new Hero("Рыцарь", health: 120);
            Hero org = new Hero("орк", health: 150);

            // Создаём оружие и броню
            Bow crocodilo = new Bow("crocodilo bombordilo", 20, Rarity.Uncommon, 2 );
            Shield tralaleloTralala = new Shield("tralaleloTralala", 14, Rarity.Epic, 1, 0);

            // Экипируем героев
            warrior.EquipWeapon(crocodilo);
            warrior.EquipArmor(tralaleloTralala);
            org.EquipArmor(tralaleloTralala);
            org.EquipWeapon(crocodilo);

            // Цикл боя
            while (warrior.IsAlive() && org.IsAlive())
            {
                Console.WriteLine("-------------------");
                warrior.ShowStatus();
                Console.WriteLine("-------------------");            
                org.ShowStatus();
                Console.WriteLine("-------------------");

                // Атака по очереди
                warrior.Attack(org);


                org.Attack(warrior);


                Console.WriteLine("Нажмите Enter для следующего хода...");
                Console.ReadLine();
            }

            // Результат боя
            Console.WriteLine("Бой окончен!");
            Console.WriteLine(warrior.IsAlive() ? $"{warrior.Name} победил!" : $"{org.Name} победил!");
        }
    }
}