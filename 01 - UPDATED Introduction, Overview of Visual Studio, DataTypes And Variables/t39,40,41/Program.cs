// implicitely type variable
// var بر اساس اون مقداری که بهش میدیم، تایپش رو مشخص میکنه
var userName = "Sara";
var userFamilyName = "Austin";
var userAge = 22;

string fullName = userName + userFamilyName;    //وقتی تایپ رو اولش میاریم در واقع داریم از explicitely استفاده میکنیم
// or
var fullName2 = userName + userFamilyName;

Console.WriteLine(fullName);
Console.WriteLine(fullName2);
//================================================
// order of evaluation
int num1 = 12;
int num2 = 5;

// concatination
Console.WriteLine("concatenation of both number is = " + num1 + num2);
// addition
Console.WriteLine("addition of both number is = "+ (num1 + num2));
//subtraction
Console.WriteLine("subttraction of both number is = " + (num1 - num2));
//multiplication
Console.WriteLine("multipulication of both number is = "+ (num1 * num2));   //اینجا اگه پرانتز هم نمیزاشتیم اوکی بود چون ضرب مقدم تره
//division
Console.WriteLine("division of both number is = "+ (num1/num2));
//================================================
//debugging
/*
 برای اینکه متوجه بشیم الان خطمون توی چه وضعیتیه و مقدار یا تایپش چیه اون خط رو میگیریم واز 
Shift + F9
استفاده میکنیم
 */
var num3 = 14;
Console.WriteLine("write your number please:");
var num4 = int.Parse(Console.ReadLine());
Console.WriteLine("concatenation of both number is = " + num3 + num4);
Console.WriteLine("division of both number is = " + (num3 / num4));