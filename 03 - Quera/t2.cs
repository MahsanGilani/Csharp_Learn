string[] input = Console.ReadLine().Split(' ');
double a = double.Parse(input[0]);      //لیتر آب داریم
double b = double.Parse(input[1]);
double c = double.Parse(input[2]);

double average = (a + b + c) / 3;

if ((a == average) && (b == average) && (c == average))
{
    Console.WriteLine(0);
}
else if ((a == average) || (b == average) || (c == average))
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(2);
}
