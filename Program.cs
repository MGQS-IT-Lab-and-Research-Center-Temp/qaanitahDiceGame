// See https://aka.ms/new-console-template for more information

Console.WriteLine("========Simple Dice Game======= \nType 'Start' or 'S' to roll dice");

string startGame = Console.ReadLine()!;

while(!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Enter the correct value");
     startGame = Console.ReadLine()!;
    
}

// if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
// {
//     Console.WriteLine("Enter 'Start' or 'S' to start the game properly");

//     return;
//}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1,7);
int originalScore = diceOne + diceTwo +diceThree;
const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;

if ( diceOne == diceTwo && diceOne == diceThree)
{
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled triple! You have a {totalPoint} Points");
}

if (diceOne ==  diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled double! You have a {totalPoint} Points");
}
else 
{
    Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou have a {totalPoint} Points");
}

if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulations! You've won a balloon");
}
else if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulations! You've won an exercise book");
}
else if (totalPoint == 17)
{
    Console.WriteLine("Congratulations! You've won a power bank");
}
else if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulations! You just won a ticket to silverbird cinema");
}
else if (totalPoint == 21)
{
    Console.WriteLine("Wow! You just rolled the lucky number, your lucky gift is Samsung A21");
}
else if (totalPoint >= 22 && totalPoint <= 24)
{
    Console.WriteLine("Congratulations! You've won all the items");
}
else
{
    Console.WriteLine("Sorry, try again later!");
}




