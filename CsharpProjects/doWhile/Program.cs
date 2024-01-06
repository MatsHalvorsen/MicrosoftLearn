/*
Random random = new Random();
int current = 0;

do 
{
    current = random.Next(1,11);
    Console.WriteLine(current);
} while (current != 7);


Random random = new Random();
int current = random.Next(1,11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1,11);
}
Console.WriteLine($"Last number: {current}");


Random random = new Random();
int current = random.Next(1,11);

do
{
    current = random.Next(1,11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/

Random randomAttack = new Random();

int heroHealth = 10;
int monsterHealth = 10;

do
{
    int attack = randomAttack.Next(1,11);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was dameged and lost {attack} health and has now {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    attack = randomAttack.Next(1,11);
    heroHealth -= attack;
    Console.WriteLine($"Hero was dameged and lost {attack} health and has now {heroHealth} health.");

}while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins": "Monster wins");