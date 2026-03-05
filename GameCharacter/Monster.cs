using System;

class Monster : IAttacker, IDefender
{
    public string Name { get; set; }
    public int AttackPower { get; set; }

    public int CurrentHp { get; set; }

    public int MaxHp { get; set; }

    public bool IsDead { get; set; }

    public Monster(string name, int maxHp, int attackPower)
    {
        Name = name;
        MaxHp = maxHp;
        AttackPower = attackPower;
        CurrentHp = MaxHp;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}이(가) {target}에게 {AttackPower} 대미지! ");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        CurrentHp -= damage;
        if( CurrentHp < 0)
        {
            IsDead = true;
            CurrentHp = 0;
        }
        

        Console.WriteLine($"({Name} HP: {CurrentHp}/{MaxHp})");
        if (IsDead == true)
        {
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
        }
    }

    public override string ToString()
    {
        return Name;
    }
}