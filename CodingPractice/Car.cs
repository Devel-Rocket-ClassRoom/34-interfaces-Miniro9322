using System;

namespace case1
{
    class Car : ICar
    {
        public void Go()
        {
            Console.WriteLine("자동차가 달립니다.");
        }
    }
}

namespace case2
{
    class Car
    {
        private IBattery _battery;

        public Car(IBattery battery)
        {
            this._battery = battery;
        }

        public void Run()
        {
            Console.WriteLine($"{_battery.GetName()}를 장착한 자동차가 달립니다.");
        }
    }
}

namespace case3
{
    class Car : Vehicle, IStandard
    {

        public void Run()
        {
            Console.WriteLine("전진");
        }

        public override void Back()
        {
            Console.WriteLine("후진");
        }
    }
}