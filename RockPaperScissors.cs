const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose Rock, Paper or Scissors: ");

string playerMove = Console.ReadLine();

if (playerMove == "Rock")
{
    playerMove = Rock;
}
else if (playerMove == "Paper")
{
    playerMove = Paper;
}
else if (playerMove == "Scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try again...");
    return;
}
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}
Console.WriteLine($"The computer chose {computerMove}.");

if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
    {
    Console.WriteLine("You win.");
}
else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
{
    Console.WriteLine("You lose.");
}
else if ((playerMove == Rock && computerMove == Rock) || (playerMove == Paper && computerMove == Paper) || (playerMove == Scissors && computerMove == Scissors))
{
    Console.WriteLine("Draw");
}