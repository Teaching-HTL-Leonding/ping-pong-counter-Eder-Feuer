int points1 = 0, points2 = 0, games1 = 0, games2 = 0;

string gamemode;
int numberofgames = 0;
int winner;

Console.WriteLine("Gamemode?");
gamemode = Console.ReadLine()!;

switch (gamemode)
{
    case "short":
        numberofgames = 1;
        break;
    case "regular":
        numberofgames = 4;
        break;
    case "double":
        numberofgames = 3;
        break;
}

do
{
    points1 = 0;
    points2 = 0;
    
    do
    {
    
        Console.WriteLine("Who has won? ");
        winner = int.Parse(Console.ReadLine()!);
        if (winner == 1)
        {
            points1++;
        }
        else if (winner == 2)
        {
            points2++;
        }
        Console.WriteLine("Points: " + points1 + " : " + points2);
    
    }
    while (points1 < 11 && points2 < 11);
    if (points1 == 11)
    {
        Console.WriteLine("Player 1 has won the game");
        games1++;
    }
    else if (points2 == 11)
    {
        Console.WriteLine("Player 2 has won the game");
        games2++;
    }
    Console.WriteLine("Games: " + games1 + " : " + games2);
}
while (games1 != numberofgames && games2 != numberofgames);


if (games1 == numberofgames)
{
    Console.WriteLine("congrats, player 1, you won the match");
}
else if (games2 == numberofgames)
{
    Console.WriteLine("Congrats, player 2, you won the match");
}
