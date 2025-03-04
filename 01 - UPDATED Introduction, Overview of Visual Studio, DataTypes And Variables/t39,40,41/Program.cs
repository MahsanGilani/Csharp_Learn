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

// concatenation
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