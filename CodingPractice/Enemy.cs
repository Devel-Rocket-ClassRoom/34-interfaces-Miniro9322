using System;

class Enemy : IDamageagle
{
    public int Health { get; private set; }

    public Enemy(int health)
    {
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        Console.WriteLine($"적이 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}