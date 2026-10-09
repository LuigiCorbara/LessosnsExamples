using BlaisePascal.LessonsExamples.Domain;
using static System.Console;

public class Program
{ 
    static void Main(string[] args)
    {
        Enemy enemy = new Enemy("Goblin", 10, 3);
        WriteLine($"{nameof(enemy)} max health is {enemy.Health}");
        enemy.TakeDamage(25);
        WriteLine("Enemy's health after attack is: " + enemy.Health);
        WriteLine("Is Enemy Alive? " + enemy.IsAlive());
    }
}

