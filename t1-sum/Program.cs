// See https://aka.ms/new-console-template for more information
// get first number
Console.WriteLine("Please write your first number: ");
string Number1 = Console.ReadLine();
// change string to integer
int num1 = int.Parse(Number1);
//get second number
Console.WriteLine("and your second number: ");
string Number2 = Console.ReadLine();
// change string to integer
int num2 = int.Parse(Number2);
// calculating the sum
Console.WriteLine($"sum = {num1 + num2}");

