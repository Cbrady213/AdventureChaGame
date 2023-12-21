public class Enemy

{
    public int EnemyHealth {get;set;} = 100;
    public int EnemyDamage {get;set;} = 500;
    public int EnemyDefence {get;set;} = 30;



    public void TakeDamage(int damage)
    {

        EnemyHealth = EnemyHealth - damage;

        Console.WriteLine($"Enemy has been hit for {damage} there health is now {EnemyHealth}");



    }



}