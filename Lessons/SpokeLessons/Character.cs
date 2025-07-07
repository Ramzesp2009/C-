namespace SpokeLessons;

public class Character
{
    private int speed;
    public int Health { get; set; } = 100;

    public Race Race { get; private set; }

    public int Armor { get; private set; }

    public Character(Race race)
    {
        Race = race;
        Armor = 30;
    }

    public Character(Race race, int armor)
    {
        Race = race;
        Armor = (int)race;
    }

    public Character(Race race, int armor, int speed)
    {
        Race = race;
        Armor = (int)race;
        this.speed = speed;
    }

    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }
        Health -= damage;
    }
    public void PrintSpeed()
    {
        Console.WriteLine($"Character speed: {speed}");
    }
    public void IncreaseSpeed()
    {
        speed += 10;
    }
}