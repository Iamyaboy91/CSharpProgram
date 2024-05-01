decimal hero = 10;
decimal monster = 10;
Random random = new Random();
int valueAttack = random.Next(1, 11);

do
{
    valueAttack = random.Next(1, 11);
    monster -= valueAttack;
    Console.WriteLine($"Monster was damaged and lost {valueAttack} health and now has {monster} health.");
    
    if (monster <= 0) continue;
    valueAttack = random.Next(1, 11);
    hero -= valueAttack;
    Console.WriteLine($"Hero was damaged and lost {valueAttack} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
/*
The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
The do-while statement: conditionally executes its body one or more times.
The while statement: conditionally executes its body zero or more times.
*/