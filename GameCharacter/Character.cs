using System;

class Character : IAttacker, IDefender
{
    public string Name { get; set; }
    public int AttackPower { get; set; } = 20;

    public int CurrentHp { get; set; }

    public int MaxHp { get; set; } = 100;

    public bool IsDead { get; set; }

    public Character(string name)
    {
        Name = name;
        CurrentHp = MaxHp;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}(이/가) {target}에게 {AttackPower} 대미지! ");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        CurrentHp -= damage;
        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }

        Console.WriteLine($"({Name} HP: {CurrentHp}/{MaxHp})");
        if( CurrentHp <= 0)
        {
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
        }
    }

    public override string ToString()
    {
        return Name;
    }
}