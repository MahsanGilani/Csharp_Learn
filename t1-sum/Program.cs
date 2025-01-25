// See https://aka.ms/new-console-template for more information

//initialize my numbers
int num1 = 0;
int num2 = 0;
// get first number
Console.WriteLine("Please write your first number: ");
string userinput = Console.ReadLine();
// change string to integer
int num1 = int.Parse(userinput);
//get second number
Console.WriteLine("and your second number: ");
string userinput = Console.ReadLine();
// change string to integer
int num2 = int.Parse(userinput);
// calculating the sum
Console.WriteLine($"sum = {num1 + num2}");

