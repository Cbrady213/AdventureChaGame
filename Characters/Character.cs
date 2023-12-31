

namespace AdventureChaGame.Characters;


public class Character

{
    // Attributes that change for each character type
    public virtual int PhysDamage { get; set; } = 50;
    public virtual int PhysDefence { get; set; } = 80;
    public virtual int MagDamage { get; set; } = 10;
    public virtual int MagDefence { get; set; } = 30;


    // Character wide attributes
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }

    public void PrintCharacter()
    {

        Console.WriteLine($"Welcome {Name} You are {Age} Years old and a {Gender}");

        Console.WriteLine($"Your Characters Physical Damage is: {PhysDamage}");
        Console.WriteLine($"And you do the following amount of damage: {DoPhysDamage(PhysDamage)}");
        Console.WriteLine($"Your Physical defence is curently set as {PhysDefence}");
        Console.WriteLine($"Your Magic Stats are:  Attack : {MagDamage} & Defence : {MagDefence}");


    }
    //attacks using characters physical damage stats
    public int DoPhysDamage(int damageVal)
    {
        int hitDamage;

        hitDamage = damageVal / 2;


        return hitDamage;


    }

    //Returns damage taken due to physical attacks, gets passed enemy damage value and your char def value

    public int TakePhyscDamage(int damageVal, int defenceVal)
    {
        int hitDamage;

        hitDamage = damageVal / defenceVal;


        return hitDamage;


    }



}

