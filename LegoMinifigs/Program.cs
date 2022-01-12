using System;
using LegoMinifigs.Legos;

namespace LegoMinifigs
{
    class Program
    {
        static void Main(string[] args)
        {
            var minifig1 = new Minifigs();
            minifig1.Head = "Han Solo Head";
            minifig1.Hat = "Storm Trooper Hat";
            minifig1.Legs = "Yoda Legs";
            minifig1.Torso = "Harry Potter Torso";
            minifig1.Accessories = "Indiana Jones Revolver";
            minifig1.OneHundred = true;

            if (minifig1.Accessories == "Indiana Jones Revolver")
            {
                minifig1.SpecialAttack();
            } else
            {
                Console.WriteLine("All Outta Bullets!");
            }

            if (minifig1.OneHundred == true)
            {
                minifig1.Unlockable();
            }

            if (minifig1.Legs == "Yoda Legs")
            {
                minifig1.DoubleJump();
            }

            var minifig2 = new Minifigs();
            minifig2.Head = "Luke Skywalker Head";
            minifig2.Hat = "Darth Vader Helmet";
            minifig2.Legs = "Batman Legs";
            minifig2.Torso = "Batman Torso";
            minifig2.Accessories = "Blue Lightsaber";
            minifig2.OneHundred = false;

            if (minifig2.OneHundred == true)
            {
                minifig2.Unlockable();
            } else
            {
                Console.WriteLine("You still have more levels to complete.");
            }

            if (minifig2.Accessories == "Blue Lightsaber")
            {
                minifig2.LightsaberAttack();
            }
        }
    }
}
