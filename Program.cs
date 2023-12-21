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



        if (readIn == "Knight")
        {


            ap = new Knight { Name = "Ben", Age = 13, Gender = "Male" };


        }

        else if (readIn == "Character")
        {

            //Character ap2;

            ap = new Character { Name = "ap", Age = 12, Gender = "female" };


        }

        else if (readIn == "Wizard")
        {

            //Character ap2;

            ap = new Wizard { Name = "Balamb", Age = 102, Gender = "Male" };


        }





        ap.PrintCharacter();

        ap.TakePhyscDamage(detectiveDuck.EnemyDamage, ap.PhysDefence);


        


    }
}
