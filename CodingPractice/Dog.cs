using System;

class Dog : IAnimal, case1.IDog
{
    public void Eat()
    {
        Console.WriteLine("먹습니다.");
    }

    public void Bark()
    {
        Console.WriteLine("짖습니다.");
    }
}