using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigs.Legos
{
    class Minifigs
    {
        public string Head { get; set; }
        public string Hat { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }
        public bool OneHundred { get; set; }

        public void SpecialAttack()
        {
            Console.WriteLine("Pew Pew!");
        }

        public void Unlockable()
        {
            Console.WriteLine("You have completed this game!");
        }

        public void DoubleJump()
        {
            Console.WriteLine($"Since you have {Legs} you can double jump!");
        }

        public void LightsaberAttack()
        {
            Console.WriteLine("You can use the lightsaber attack!");
        }
    }
}
