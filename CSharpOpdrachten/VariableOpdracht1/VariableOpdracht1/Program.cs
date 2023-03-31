using System;

namespace VariableOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Character stats (name, hp and strength respectively.)");

            //maak hier 3 local variables aan:
            //1 type=string, naam: name, waarde je favoriete rpg character
            string name = "Sephiroth";
            //2 type=int, naam: hp, een waarde van hoeveel health dit character heeft
            int hp = 400000;
            //3 type=int, naam: str, een waarde van hoe sterk dit character is
            int str = 246;


            //nu zou de statement hieronder moeten werken
            Console.WriteLine($"{name} {hp} {str}");
        }
    }

}