/*
    logical operators یا عملگرهای منطقی
    And = اگر هر دو مقدار true داشته باشند
            در این صورت نتیجه true خواهد
            در غیر این صورت مقدار false میگیرد
    OR = اگر حداقل یکی از مقادیر true باشد
            مقدار نتیجه برابر با true خواهد بود
            در غیر اینصورت false
    Not = نتیجه رو معکوس میکند
    XOR = در صورتیکه هر دوتا مقدارشون برابر بود، نتیجه ی نهایی برابر با false
                و در صورتیکه مقادیر نابرابر داشتند، مقدار نهاییشون برابر با true میشود.
 */

//==============================================

bool isRainy = false;
bool hasUmbrella = true;

if (isRainy)  // درصورتیکه مقدار داخل پرانتز برابر با true باشد، کد پایین اجرا میشود
{
    Console.WriteLine("oh it's rainy");
}

Console.WriteLine("ummmm it's sunny");
Console.ReadKey();
