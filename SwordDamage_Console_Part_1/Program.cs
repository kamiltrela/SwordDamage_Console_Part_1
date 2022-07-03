using System;

namespace SwordDamage_Console_Part_1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create instances of SwordDamage and Random
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            Console.WriteLine("Welcome to the Sword Damage Calculator!");

            // Run the damage calculating loop until terminated by the user
            while(true)
            {
                Console.Write("0 for no magic or flaming, 1 for magic, 2 for flaming, " +
                    "3 for both, anything else to quit: ");

                char key = Console.ReadKey(false).KeyChar;
                Console.WriteLine();

                // Exit loop if user enters invalid key
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                // Simulate rolling 3d6 (6-sided die rolled 3 times), set result to SwordDamage roll
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;

                // If user enters 1 or 3, set using magic to true
                swordDamage.SetMagic(key == 1 || key == 3);

                // If user enters 2 or 3, set using flame to true
                swordDamage.SetFlaming(key == 2 || key == 3);

                Console.WriteLine("You rolled {0} for {1} damage!\n", swordDamage.Roll, swordDamage.Damage);




            } 
        }
    }
}
