// See https://aka.ms/new-console-template for more information

//initialize my numbers
int num1 = 0;
int num2 = 0;
// get first number
Console.WriteLine("Please write your first number: ");
string userInput = Console.ReadLine();
// change string to integer
num1 = int.Parse(userInput);
//get second number
Console.WriteLine("and your second number: ");
userInput = Console.ReadLine();
// change string to integer
num2 = int.Parse(userInput);
// calculating the sum
Console.WriteLine($"sum = {num1 + num2}");
//====================================================
double num3 = 0.0;
double num4 = 0.0;

Console.WriteLine("Enter a number: ");
userInput = Console.ReadLine();
num3 = double.Parse(userInput);
Console.WriteLine("Enter a number: ");
userInput = Console.ReadLine();
num4 = double.Parse(userInput);
double sum = num3 + num4;
// rounding sum to 2 decimal places
sum = Math.Round(sum, 2);
Console.WriteLine($"{num3} + {num4} = {sum}");
