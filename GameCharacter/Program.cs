using System;

// README.md를 읽고 코드를 작성하세요.

Character player = new Character("용사");
Monster slime = new Monster("슬라임", 30, 5);

Console.WriteLine("=== 전투 시작 ===\n");
player.Attack(slime);
slime.Attack(player);
player.Attack(slime);

Console.WriteLine("\n=== 고블린 등장 ===\n");
Monster goblin = new Monster("고블린", 50, 10);
player.Attack(goblin);
goblin.Attack(player);
player.Attack(goblin);
player.Attack(goblin);