
int rollDice, playerPos = 0;

Random random = new Random();

var list = new List<string> { "No Play", "Ladder", "Snake" };

rollDice = random.Next(1, 7);
Console.WriteLine("Dice number is : " + rollDice);

Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");


int index = random.Next(list.Count);
Console.WriteLine("Player option is : " + list[index]);
if (playerPos + rollDice < 100)
{
    if (list[index] == "Ladder") playerPos += rollDice;
    if (list[index] == "Snake") playerPos -= rollDice;
}

if (playerPos < 0)
{
    playerPos = 0;
}

Console.WriteLine("\n");
Console.WriteLine("Player current position : " + playerPos);
Console.WriteLine("Final position is :" + playerPos);
