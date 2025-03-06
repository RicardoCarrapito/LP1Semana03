using System;
using HeroPerks;
using System.Diagnostics.CodeAnalysis;
namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
        
            Perks myPerks = new Perks();
            bool skip = false;

           

            foreach (char cr in args[0])
            {
                
                switch (cr)
                {
                    case 'w':
                        myPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        myPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        myPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        myPerks ^= Perks.DoubleJump;
                        break;
                    
                    default:
                        skip = true;
                        Console.WriteLine("!Unknown perk!");
                        break;
                }
            }

            
            if (skip == false)
            {
                
                if (vazio(myPerks))
                    Console.WriteLine(myPerks);

              
                if ((myPerks & Perks.Stealth) == Perks.Stealth &&
                (myPerks & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("!Silent jumper!");
                }

              
                if (vazio(myPerks))
                {
                    Console.WriteLine("!No perks at all!");
                }

                
                if ((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
        }

        
        private static bool vazio(Perks perks)
        {
            bool empty = false;
            if (perks == 0)
                empty = true;

            return empty;

           

            
        }
    }
}
