using System.Security.Cryptography.X509Certificates;
using AdventureChaGame.Characters;

namespace AdventureChaGame;

class Program
{
    
    static void Main(string[] args)
    {


        Character ap = null;
        Enemy detectiveDuck = new Enemy{};

        



        string? readIn;

        Console.WriteLine($"Please type the type of character you wish to create: ");
        readIn = Console.ReadLine();
        readIn = readIn.ToLower();



        if (readIn == "knight")
        {


            ap = new Knight { Name = "Ben", Age = 13, Gender = "Male" };


        }

        else if (readIn == "character")
        {

            //Character ap2;

            ap = new Character { Name = "AP", Age = 12, Gender = "Penguin" };


        }

        else if (readIn == "wizard")
        {

            //Character ap2;

            ap = new Wizard { Name = "Balamb", Age = 102, Gender = "Male" };


        }





        ap.PrintCharacter();

        ap.TakePhyscDamage(detectiveDuck.EnemyDamage, ap.PhysDefence);
        ap.DoPhysDamage(ap.PhysDamage,detectiveDuck.EnemyDefence);

        detectiveDuck.TakeDamage(ap.DoPhysDamage(ap.PhysDamage,detectiveDuck.EnemyDefence));


        


    }
}
