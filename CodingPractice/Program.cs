using System;

// README.md를 읽고 코드를 작성하세요.

//1-1
case1.Car car1 = new case1.Car();
car1.Go();

//1-2
IRepository repository = new Repository();
repository.Get();

//1-3
Person person = new Person();
person.Work();
person.Rest();

//2
case2.Car goodCar = new case2.Car(new GoodBattery());
case2.Car normalCar = new case2.Car(new NormalBattery());

goodCar.Run();
normalCar.Run();

//3-1
Dog dog = new Dog();
dog.Eat();
dog.Bark();

//3-2
Bird bird = new Bird();
bird.Breathe();
bird.Fly();

//4-1
Pet pet = new Pet();

((case2.IDog)pet).Eat();
((ICat)pet).Eat();

case2.IDog dog2 = new Pet();
ICat cat = new Pet();

dog2.Eat();
cat.Eat();

//4-2
Example example = new Example();
IExample ex = example;

ex.DoWork();

//5
TextEditor textEditor = new TextEditor();
textEditor.Undo();
textEditor.Redo();

//6
case3.Car car3 = new case3.Car();
car3.Run();
car3.Left();
car3.Back();

//7-1
Player player = new Player(100);
Enemy enemy = new Enemy(50);
Building building = new Building(500);

player.TakeDamage(20);
enemy.TakeDamage(30);
building.TakeDamage(100);

//7-2
Hero hero = new Hero();
Turret turret = new Turret();

hero.Move();
hero.Attack();
turret.Attack();