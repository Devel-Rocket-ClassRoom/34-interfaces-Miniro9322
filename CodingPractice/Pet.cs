using System;

class Pet : case2.IDog, ICat
{
    void case2.IDog.Eat()
    {
        Console.WriteLine("개처럼 먹습니다.");
    }

    void ICat.Eat()
    {
        Console.WriteLine("고양이처럼 먹습니다.");
    }
}