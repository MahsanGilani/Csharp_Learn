//string input = Console.ReadLine();
//int a = int.Parse(input.Split(' ')[0]);
//int b = int.Parse(input.Split(' ')[1]);
//if (a < b)
//{
//    Console.WriteLine(a);
//}
//else if (a == b)
//{
//    Console.WriteLine(a + " = " + b);
//}
//else
//{
//    Console.WriteLine(b);
//}

//***************************************************************
//string input = Console.ReadLine();
//float number = float.Parse(input);
//if (number < 10.0)
//{
//    Console.WriteLine("Fail");
//}
//else
//{
//    Console.WriteLine("Pass");
//}

//***************************************************************
//string input = Console.ReadLine();
//float T = float.Parse(input);
//if (T > 100.0)
//{
//    Console.WriteLine("Steam");
//}
//else if (T < 0.0)
//{
//    Console.WriteLine("Ice");
//}
//else
//{
//    Console.WriteLine("Water");
//}

//***************************************************************
//int n = int.Parse(Console.ReadLine());
//if ( 1000 <= n && n < 10000)
//{
//    Console.WriteLine("4");
//}
//else if (100 <= n && n < 1000)
//{
//    Console.WriteLine("3");
//}
//else if (10 <= n && n < 100)
//{
//    Console.WriteLine("2");
//}
//else
//{
//    Console.WriteLine("1");
//}

//***************************************************************
//string input = Console.ReadLine();
//Console.WriteLine(input.Length);

//***************************************************************

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//int[] myList = new int[] { a, b, c, d };

//int maxA = Math.Max(a, b);
//int maxB = Math.Max(c, d);
//int maxTotal  = Math.Max(maxA , maxB);
//Console.WriteLine(maxTotal);

//***************************************************************
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());
//int max = 0;

//if (a > b)
//{
//    max = a;
//}
//else
//{
//    max = b;
//}

//if (max < c)
//{
//    max = c;
//}

//if (max < d)
//{
//    max = d;
//}
//Console.WriteLine(max);

//***************************************************************
//if (1 == 1 && 2 == 1)
//{
//    Console.WriteLine("shart 2 == 1 ghalate!");
//}
//else if (2 == 1 && 1 == 1)
//{
//    Console.WriteLine("inja ham shart 2 == 1 ghalate");
//}
//else if (2 == 2 && 1 < 2)
//{
//    Console.WriteLine("Ahsant! in dastoor ejra mishe");
//}

//***************************************************************
//if (3 == 2 || 1 > 2)
//{
//    Console.WriteLine("man print misham!");
//}
//else if (1 == 1 || 1 > 2)
//{
//    Console.WriteLine("man chap misham?");
//}

//***************************************************************
//bool x = true;
//bool y = false;

//Console.WriteLine(x && y);
//Console.WriteLine(x || y);

//***************************************************************

//bool x, y;
//x = bool.Parse(Console.ReadLine());
//y = bool.Parse(Console.ReadLine());

//Console.WriteLine(x);
//Console.WriteLine(y);

//***************************************************************

//if (false)
//{
//    Console.WriteLine("Hello World");
//}
//if (true)
//{
//    Console.WriteLine("Hello Quera Collage");
//}

//***************************************************************
//string[] input = Console.ReadLine().Split(' ');

//int a = int.Parse(input[0]);
//int b = int.Parse(input[1]);
//int c = int.Parse(input[2]);

//if (a + b < c || a + c < b || c + b < a)
//{
//    Console.WriteLine("Na");
//}
//else
//{
//    Console.WriteLine("Bale");
//}

//***************************************************************
//string[] input = Console.ReadLine().Split(' ');

//int a = int.Parse(input[0]);
//int b = int.Parse(input[1]);
//int c = int.Parse(input[2]);

//if ( a + b + c == 180 && ( a + b == 90.0 || b + c == 90.0 ||  a + c == 90))
//{
//    if (a == 0 || b== 0 || c== 0)
//    {
//        Console.WriteLine("Na");
//    }
//    else
//    {
//        Console.WriteLine("Bale");
//    }
//}
//else
//{
//    Console.WriteLine("Na");
//}

//***************************************************************
//string input = Console.ReadLine();

//if ((input.Contains("R R B")) || (input.Contains("R R G")))
//{
//    Console.WriteLine("Ghermezo Eshghe!");
//}
//else if ((input.Contains("B R B")) || (input.Contains("B G B")) || (input.Contains("B B G")) || (input.Contains("B B R")))
//{
//    Console.WriteLine("Abio Eshghe!");
//}
//else
//{
//    Console.WriteLine("Doost Nadaram!");
//}

//***************************************************************
//string[] input1 = Console.ReadLine().Split(' ');
//string[] input2 = Console.ReadLine().Split(' ');
//string[] input3 = Console.ReadLine().Split(' ');

//int a = int.Parse(input1[0]);
//int b = int.Parse(input1[1]);
//int c = int.Parse(input2[0]);
//int d = int.Parse(input2[1]);
//int e = int.Parse(input3[0]);
//int f = int.Parse(input3[1]);
//int g = 0;
//int h = 0;

//if (a == c)
//{
//    g = e;
//}
//if (a == e)
//{
//    g = c;
//}
//if (e == c)
//{
//    g = a;
//}
//if (b == d)
//{
//    h = f;
//}
//if (b == f)
//{
//    h = d;
//}
//if (f == d)
//{
//    h = b;
//}

//Console.WriteLine(g + " " + h);

//***************************************************************
//string[] input1 = Console.ReadLine().Split();
//string[] input2 = Console.ReadLine().Split();
//string[] input3 = Console.ReadLine().Split();

//int x1 = int.Parse(input1[0]), y1 = int.Parse(input1[1]);
//int x2 = int.Parse(input2[0]), y2 = int.Parse(input2[1]);
//int x3 = int.Parse(input3[0]), y3 = int.Parse(input3[1]);

//int fourthX = x1 ^ x2 ^ x3;
//int fourthY = y1 ^ y2 ^ y3;

//Console.WriteLine($"{fourthX} {fourthY}");

//***************************************************************
//int input1 = int.Parse(Console.ReadLine());
//int input2 = int.Parse(Console.ReadLine());

//// برعکس کردن x
//int x = input1 % 10;
//int x1 = (input1 / 10)%10;
//int x2 = input1 / 100;
//string xNahayi = $"{x}{x1}{x2}";
//// برعکس کردن y
//int y = input2 % 10;
//int y1 = (input2 / 10) % 10;
//int y2 = input2 / 100;
//string yNahayi = $"{y}{y1}{y2}";
//// تبدیل کردن به اینتجر برای مقایسه کردن
//int xx = int.Parse(xNahayi);
//int yy =  int.Parse(yNahayi);

//if (yy < xx)
//{
//    Console.WriteLine($"{input2} < {input1}");
//}
//else  if (xx < yy)
//{
//    Console.WriteLine($"{input1} < {input2}");
//}
//else if (yy == xx)
//{
//    Console.WriteLine($"{input1} = {input2}");
//}

//***************************************************************
//int num = int.Parse(Console.ReadLine());
//switch (num)
//{
//    case 1:
//        Console.WriteLine("One");
//        break;
//    case 2:
//        Console.WriteLine("Two");
//        break;
//    case 3:
//        Console.WriteLine("Three");
//        break;
//}

//***************************************************************
//int num = 1;
//switch (num)
//{
//    case 1:
//    case 2:
//    case 3:
//        Console.WriteLine(3);
//        break;
//    case 4:
//        Console.WriteLine(4);
//        break;
//    case 5:
//        Console.WriteLine(5);
//        break;
//}

//***************************************************************
//float num = 3.6f;
//switch (num)
//{
//    case 1.2f:
//        Console.WriteLine(1.2);
//        break;
//    case 3.6f:
//        Console.WriteLine(3.6);
//        break;
//}


//***************************************************************
//int number = int.Parse(Console.ReadLine());
//switch (number)
//{
//    case < 10:
//        Console.WriteLine("Lower than 10");
//        break;
//    case > 10:
//        Console.WriteLine("upper than 10");
//        break;
//}

//***************************************************************
//int num = 5;
//switch (num)
//{
//    case 0:
//        Console.WriteLine("zero");
//        break;
//    case 8:
//        Console.WriteLine("eight");
//        break;
//    case 9:
//        Console.WriteLine("nine");
//        break;
//    default:
//        Console.WriteLine("BYE");
//        break;

//}

//***************************************************************
//string[] input = Console.ReadLine().Split(' ');     //ورودی گرفتن برای مقدار متغییر
//char a = char.Parse(input[0]);
//char b = char.Parse(input[1]);
//char c = char.Parse(input[2]);

//string[] input1 = Console.ReadLine().Split(' ');    //ورودی گرفتن برای مقادیر عددی
//int x = int.Parse(input1[0]);
//int y  = int.Parse(input1[1]);
//int z  = int.Parse(input1[2]);

//if ((a == b) && a!=c)
//{
//    if (x > z)
//    {
//        Console.WriteLine($"Max : {Math.Max(x , y)}");
//    }
//    else if (z > x)
//    {
//        Console.WriteLine($"Max : {Math.Max(z , y)}");
//    }
//    else if (x == z)
//    {
//        Console.WriteLine($"Max : {Math.Max(x , y)}");
//    }

//}
//else if ((a == c) && a !=b)
//{
//    if (x < z)
//    {
//        Console.WriteLine($"Min : {Math.Min(x, y)}");
//    }
//    else if (z < x)
//    {
//        Console.WriteLine($"Min : {Math.Min(z, y)}");
//    }
//    else if (x == z)
//    {
//        Console.WriteLine($"Min : {Math.Max(x, y)}");
//    }
//}
//else
//{
//    Console.WriteLine("None");
//}

//***************************************************************
//int x = int.Parse(Console.ReadLine());
//if (x == 0 || x > 0)
//{
//    Console.WriteLine(x);
//}
//else if (x > 0 && x / 2 == 0)
//{
//    int y = x;
//    Console.WriteLine(y);
//}
//else
//{
//    Console.WriteLine(2 * x);
//}

//***************************************************************
//int a = 9;
//if (a % 2 == 0)
//{

//}
//else
//{
//    Console.WriteLine("This number is Odd");
//}

//***************************************************************
//int number = int.Parse(Console.ReadLine());
//if (number % 2 == 0) Console.WriteLine("Zoj");
//else Console.WriteLine("fard");

//***************************************************************
//int n = int.Parse(Console.ReadLine()); 
//int m  = int.Parse(Console.ReadLine()); 
//if (n == m)
//{
//    Console.WriteLine(0);
//}
//else if (((n == 1) && (m == 2)) || ((n == 2) && (m == 1)) || ((n == 3) && (m == 4)) || ((n == 4) && (m == 3)) || ((n == 1) && (m == 3)) || ((n == 3) && (m == 1)) || ((n == 4) && (m == 2)) || ((n == 2) && (m == 4)))
//{
//    Console.WriteLine(1);
//}
//else
//{
//    Console.WriteLine(2);
//}

//***************************************************************

//int n = int.Parse(Console.ReadLine());      //مبتلایان شکرستان
//int k = int.Parse(Console.ReadLine());      //فوتی شکرستان

//int p = int.Parse(Console.ReadLine());      //مبتلایان نمکستان
//int q = int.Parse(Console.ReadLine());      //فوتی نمکستان

//int besh = n -  k;
//int benam = p - q;

//if (besh > benam)
//{
//    Console.WriteLine("Shekarestan");
//}
//else if (benam > besh)
//{
//    Console.WriteLine("Namakestan");
//}
//else
//{
//    Console.WriteLine("Equal");
//}

//***************************************************************

//string[] input = Console.ReadLine().Split(' ');

//long a = long.Parse(input[0]); // طول جعبه
//long b = long.Parse(input[1]); // عرض جعبه
//long c = long.Parse(input[2]); // ارتفاع جعبه
//long d = long.Parse(input[3]); // ضلع اول یخ
//long e = long.Parse(input[4]); // ضلع دوم یخ
//long f = long.Parse(input[5]); // ضلع سوم یخ

//// حالت‌های مختلف چیدن کف یخ روی زمین:
//// اولین عبارت قبل از اند میشه طول و بعدی هم بررسی عرض هستش
//bool fit1 = (Math.Max(a, b) >= Math.Max(d, e) && Math.Min(a, b) >= Math.Min(d, e));
//bool fit2 = (Math.Max(a, b) >= Math.Max(d, f) && Math.Min(a, b) >= Math.Min(d, f));
//bool fit3 = (Math.Max(a, b) >= Math.Max(e, f) && Math.Min(a, b) >= Math.Min(e, f));

//if (fit1 || fit2 || fit3)
//{
//    Console.WriteLine("zende mimuni");
//}
//else
//{
//    Console.WriteLine("dari mimiri");
//}

//***************************************************************
//string[] input = Console.ReadLine().Split(' ');
//double a = double.Parse(input[0]);      //لیتر آب داریم
//double b = double.Parse(input[1]);
//double c = double.Parse(input[2]);

//double average = (a + b + c) / 3;

//if ((a == average) && (b == average) && (c == average))
//{
//    Console.WriteLine(0);
//}
//else if ((a == average) || (b == average) || (c == average))
//{
//    Console.WriteLine(1);
//}
//else
//{
//    Console.WriteLine(2);
//}

//***************************************************************
string[] input = Console.ReadLine().Split(' ');
int k = int.Parse(input[0]);
int a = int.Parse(input[1]);
int b = int.Parse(input[2]);




