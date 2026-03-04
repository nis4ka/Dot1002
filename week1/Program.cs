//exercise 1
using System.Runtime.CompilerServices;

Console.Write("What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine($"Hello {userName}!");

//exercise 2
Console.Write("Please enter an integer: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter an integer again: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int ans = firstNumber + secondNumber;
Console.WriteLine(ans);

//exercise 3
Console.Write("Input 1: ");
int firstInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2: ");
int secondInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3: ");
string operation = Console.ReadLine();
if (operation == "add")
{
    int answer = firstInput + secondInput;
    Console.WriteLine($"Answer is {answer}. ({firstInput} + {secondInput} = {answer})");
}
else if (operation == "substract")
{
    int answer = firstInput - secondInput;
    Console.WriteLine($"Answer is {answer}. ({firstInput} - {secondInput} = {answer})");
}
else if (operation == "multiply")
{
    int answer = firstInput * secondInput;
    Console.WriteLine($"Answer is {answer}. ({firstInput} * {secondInput} = {answer})");
}
else if (operation == "division")
{
    int answer = firstInput / secondInput;
    Console.WriteLine($"Anser is {answer}. ({firstInput} / {secondInput})");
}

//exercise 4
Console.Write("Input 1: ");
string inputFirst = Console.ReadLine();
Console.Write("Input 2: ");
string inputSecond = Console.ReadLine();
Console.Write("Input 3: ");
string inputThird = Console.ReadLine();

double firstNum;
double secondNum;
string op = inputThird;
bool isFirstInputCorrect = double.TryParse(inputFirst, out firstNum);
bool isSecondInputCorrect = double.TryParse(inputSecond, out secondNum);
bool isThirdInputCorrect = false;

if (!isFirstInputCorrect)
{
Console.WriteLine("Input 1 is wrong type");
}
if (!isSecondInputCorrect)
{
Console.WriteLine("Input 2 is wrong type");
}
if (inputThird == "add" || inputThird == "subtract" || inputThird == "multiply" || inputThird
== "divide")
{
isThirdInputCorrect = true;
}
else
Console.WriteLine("Input 3 is wrong type");
if (isFirstInputCorrect && isSecondInputCorrect && isThirdInputCorrect)
{
if (op == "add")
{
double sum = firstNum+secondNum;
Console.WriteLine($"Answer is {sum}. ({firstNum} + {secondNum} = {sum})");
}
else if (op == "subtract")
{
double subtract = firstNum-secondNum;
Console.WriteLine($"Answer is {subtract}. ({firstNum} - {secondNum} = {subtract})");
}
else if (op == "multiply")
{
double multiply = firstNum * secondNum;
Console.WriteLine($"Answer is {multiply}. ({firstNum} * {secondNum} = {multiply})");
}
else if (op == "divide")
{
double divide = firstNum / secondNum;
Console.WriteLine($"Answer is {divide}. ({firstNum} / {secondNum} = {divide})");
}
}

//exercise 5
List<int> resultsofVanDerPoel = [1,2,1];
List<int> resultsofVanAert = [3,4,3];
List<int> resultsofPedersen = [6,3,4];

double averageVdp = resultsofVanDerPoel.Average();
double averageAert = resultsofVanAert.Average();
double averagePedr = resultsofPedersen.Average();
Console.WriteLine("Name: Standings -> Average Standing");
Console.Write("Van Der Poel: ");
foreach (int num in resultsofVanDerPoel)
{
Console.Write(num + "-");
}
Console.Write("-> " + averageVdp);

Console.Write("\nVan Aert: ");
foreach (int num in resultsofVanAert)
{
Console.Write(num + "-");
}
Console.Write("-> " + averageAert);

Console.Write("\nPedersen: ");
foreach (int num in resultsofPedersen)
{
Console.Write(num + "-");
}
Console.Write("-> " + averagePedr);

if (averageAert < averagePedr && averageVdp < averagePedr)
{
    Console.WriteLine($"\nWinner is Pedersen and his avarage standing is {averagePedr}");
}
else if (averageAert < averageVdp && averagePedr < averageVdp)
{
    Console.WriteLine($"\nWinner is Van Der Poel and his avarage standing is {averageVdp}");
}
else if (averageVdp < averageAert && averagePedr < averageAert)
{
    Console.WriteLine($"\nWinner is Van Aert and his avarage standing is {averageAert}");
}

//exercise 6
Console.WriteLine("What is the name of Cyclist?");
string cyclist = Console.ReadLine();
Console.WriteLine("How many race did he finish?");
int race = Convert.ToInt32(Console.ReadLine());
List<int> cyclistResults = new List<int>();
string helper = "";
Console.WriteLine($"What are the results for {cyclist}?");
for (int i = 0; i < race; i++)
{
    int resultofcyclist = Convert.ToInt32(Console.ReadLine());
    cyclistResults.Add(resultofcyclist);
}
foreach (int n in cyclistResults)
{
    helper += n + "-";
}
Console.WriteLine($"Results for {cyclist}: {helper}");
Console.WriteLine($"His average standing is {cyclistResults.Average()}");

//exercise 7
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);