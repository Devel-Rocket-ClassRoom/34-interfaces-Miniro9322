using System;

class Building : IDamageagle
{
    public int Health { get; private set; }

    public Building(int health)
    {
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        Console.WriteLine($"건물이 {damage} 대미지를 받음. 남은 내구도: {Health}");
    }
}