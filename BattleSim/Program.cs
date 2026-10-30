using System;

namespace BattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ім'я вашого героя:");
            string heroName = Console.ReadLine();

            Console.WriteLine("Оберіть зброю (1 - Меч, 2 - Лук, 3 - Посох):");
            string weaponChoice = Console.ReadLine();

            int damage = 0;
            string weaponName = "";

            // Перевіряємо вибір (умови)
            if (weaponChoice == "1")
            {
                damage = 25;
                weaponName = "Меч";
            }
            else if (weaponChoice == "2")
            {
                damage = 15;
                weaponName = "Лук";
            }
            else if (weaponChoice == "3")
            {
                damage = 30;
                weaponName = "Посох";
            }
            else
            {
                Console.WriteLine("Неправильний вибір! Ви отримали кулаки.");
                damage = 5;
                weaponName = "Кулаки";
            }

            int monsterHp = 100;
            int round = 1;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n--- Бій починається! {heroName} з {weaponName} проти Монстра (100 HP) ---");
            Console.ResetColor();

            while (monsterHp > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nРаунд {round}. {heroName} б'є {weaponName}ом на {damage} шкоди!");
                Console.ResetColor();

                monsterHp -= damage; // Завдаємо шкоди

                if (monsterHp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"У монстра залишилося {monsterHp} HP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Монстр переможений! Ви виграли!");
                    Console.ResetColor();
                }

                round++;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}