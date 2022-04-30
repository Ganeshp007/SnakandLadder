//local variables
int rollDice, playerPos1 = 0, playerPos2 = 0;
int count = 0;

Random random = new Random();//generating random number

var list = new List<string> { "Play", "Ladder", "Snake" };//List to check options

// 1 ->player 1 is playing . 2 ->Player 2 is playing
int playerChange = 1;
while (playerPos1 <= 100 || playerPos2 <= 100)
{
    //Print the current Player
    Console.WriteLine("Player: " + playerChange + " is playing \n");

    //Rolling dice
    rollDice = random.Next(1, 7);
    Console.WriteLine("Dice number is : " + rollDice + "\n");

    //Print user options
    Console.WriteLine("Player checks options 1.Play  2.Ladder   3.Snake \n");

    //Use random to check user option
    int index = random.Next(list.Count);
    Console.WriteLine("Player option is : " + list[index] + "\n");


    //Goes to this loop if Player 1 is rolling dice
    if (playerChange == 1)
    {
    
        if (list[index] == "Play")
        {
            playerPos1 += rollDice;
            
        }

        //If player option is "Snake" , position will go down and will change player to 2
        if (list[index] == "Snake")
        {
            playerPos1 -= rollDice;
            playerChange = 2;
        }

        //If after rolling rice player position <100 then it will increment the position of player to that of number of dice
        if (playerPos1 + rollDice < 100 && playerChange == 1)
        {
            if (list[index] == "Ladder") 
                playerPos1 += rollDice;
        }



        //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 1
        if (list[index] == "Ladder" && (playerPos1 + rollDice == 100) && playerChange == 1)
        {
            playerPos1 += rollDice;
            break;
        }

        //If after getting "Snake" option , position is less than 0, then reset position to 0
        if (playerPos1 < 0 && list[index] == "Snake")
        {
            playerPos1 = 0;
        }

        //Print to Console
        Console.WriteLine("\n");
        Console.WriteLine("Player 1 current position : " + playerPos1);
    }

    //Goes to this loop if Player 2 is rolling dice
    else if (playerChange == 2)
    {
        //If option is "No Change" it will change player to 1
        if (list[index] == "Play" )
        {
            playerPos2 += rollDice;
           
            
        } 
        
        //If player option is "Snake" , position will go down and will change player to 1
        if (list[index] == "Snake")
        {
            playerPos2 -= rollDice;
            playerChange = 1;
        }

        //If after rolling dice player position <100 then it will increment the position of player to that of number of dice
        if (playerPos2 + rollDice < 100 && playerChange == 2)
        {
            if (list[index] == "Ladder") 
                playerPos2 += rollDice;
        }

       

        //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 2
        if (list[index] == "Ladder" && (playerPos2 + rollDice == 100) && playerChange == 2)
        {
            playerPos2 += rollDice;
            break;
        }

       
        if (playerPos2 < 0 && list[index] == "Snake") //If after getting "Snake" option , position is less than 0, then reset position to 0
        {
            playerPos2 = 0;
        }

        
        Console.WriteLine("\n");
        Console.WriteLine("Player 2 current position : " + playerPos2);//Print to Console
        count++;
    }
}

Console.WriteLine("\n");

if (playerPos1 == 100)//Print winner of 2Player Game
{
    Console.WriteLine("Winner is player 1  :" + playerPos1);
    Console.WriteLine("Final position of player 2  :" + playerPos2);
}
else
{
    Console.WriteLine("Winner is player 2 :-" + playerPos2);
    Console.WriteLine("Final position of player 1 :-" + playerPos1);
}

Console.WriteLine("Number of times Dice rolled by two Players:-" + count);//Total Number of game played