// یاد آوری تابع parse
string myString = "123456";
int result = int.Parse(myString);
Console.WriteLine(result);
//==========================================
/*
 ما برای explicit conversion
از یک روش دیگه ای هم استفاده میکنیم به اسم convert
convert یک کلاس است
که ما از متدهای داخلش برای تبدیل استفاده میکنیم
قابل ذکر است همین console هم که باهاش میکنیم هم یک کلاس هستش
کلاس ها همه با حروف بزرگ یا همان پاسکال کیس نوشته میشوند
 */
string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine("mybool is "+myBool);
//===========================================
// یادمون باشه باید از مقادیری برای کانورت یا پارس استفاده کنیم که واقعا قابلیت تبدیل داشته باشند وگرنه ارور میگیریم
string? myString2 = null;
bool myBool2 = Convert.ToBoolean(myString2);
Console.WriteLine($"mybool2 is {myBool2}");
//در صورتیکه مقداری برابر با نال باشه، اون رو به فالس یا صفر برمیگردونه
//============================================
/*
 تفاوت های کلاس Convert و متد parse
متد پارس فقط برای تبدیل از استرینگ به عدد یا دابل یا دیت تایم استفاده میشه
درحالیکه کانورت همرو شامل میشه
 */
decimal myDecimal = 123454452.543434553393948m;  //برای دسیمال حتما تهش باید m بزاریم
double myDouble = Convert.ToDouble(myDecimal);
Console.WriteLine(myDouble);
// فلوت<دابل<دسیمال

Console.ReadKey();
