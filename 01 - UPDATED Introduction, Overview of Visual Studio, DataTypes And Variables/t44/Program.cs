//UTF-16 
/*
 برای تعریف متغیری از نوع char
باید حتما از سینگل کوتیشن استفاده کنیم
و هر کاراکتری که از utf16 پیروی میکنه رو میتونیم توش قرار بدیم
فقط باید دقت کنیم که تنها و تنها یک کاراکتر رو باید قرار بدیم
 */
char myFavoriteChar = '☺';
Console.WriteLine(myFavoriteChar);
//===================================================
//More String Manipulation with String Formatting

int num = 10;
float myFloat = 12.2f;
string myString = "Frank";

//Interpolation
Console.WriteLine($"The number is : {num}");
//String Concatination
Console.WriteLine("The number is : " + num);

//string Formatting
Console.WriteLine("The number is {0}, And the float is {1}, And String is {2}.", num, myFloat, myString);
// در این روش بر اساس نحوه ی قرار گیری متغیرها، از صفر و یک و الی آخر استفاده میکنیم

//============================================================