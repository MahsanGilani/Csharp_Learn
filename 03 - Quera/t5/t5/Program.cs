//// گرفتن ورودی به صورت یک خطی 
//string[] input = Console.ReadLine().Split(' ');
//// تعریف متغیرها از ورودی گرفته شده
//int a = int.Parse(input[0]); 
//int b = int.Parse(input[1]);
////تعریف دو لیست جهت ریختن مقسوم علیه های دو عدد داده شده
//List<int> resultA = new List<int>();
//List<int> resultB = new List<int>();

//// بررسی اینکه اگر باقیمانده برابر صفر شد، یعنی عدد مذکور مقسوم علیه درستی بوده و در نتیجه داخل لبست اولی ریخته میشود
//for (int i = 1; i <= a; i++)
//{
//    if (a % i == 0)
//    {
//        resultA.Add(i);
//    }
//    else
//    {
//        continue;
//    }
//}
//// بررسی اینکه اگر باقیمانده برابر صفر شد، یعنی عدد مذکور مقسوم علیه درستی بوده و در نتیجه داخل لبست دومی ریخته میشود
//for (int i = 1; i <= b; i++)
//{
//    if (b % i == 0)
//    {
//        resultB.Add(i);
//    }
//    else
//    {
//        continue;
//    }
//}

//// تعریف لیست سوم برای بررسی مقسوم علیه های مشترکات بین دو عدد
//List<int> resultC = new List<int>();

//// بررسی اینکه اگر چندتا مقسوم علیه مشترک وجود داشت، بریزه توی لیست سوم
//foreach (int i in resultA)
//{   
//    foreach (int j in resultB)
//    {
//        if (i == j )
//        {
//            resultC.Add(i);
//        }
//    }
//}

//// بدست آوردن ب م م بین دو عدد
//Console.WriteLine(resultC.Max());

//****************************************************************************************

//string[] input = Console.ReadLine().Split();
//int a = int.Parse(input[0]);
//int b = int.Parse(input[1]);

//while (b != 0)
//{
//    int temp = b;
//    b = a % b;
//    a = temp;
//}

//Console.WriteLine(a);

//****************************************************************************************
//int n = int.Parse(Console.ReadLine());

//List<int> maghsoom = new List<int>();

//// اضافه کردن مقسوم علیه های یک عدد به لیست تعریف شده 
//for (int i = 1;  i < n; i++)
//{
//    if (n % i == 0)
//    {
//        maghsoom.Add(i);
//    }
//}

//// در صورتیکه مجموع مقسوم علیه های یک عدد برابر با خود عدد باشد، آن عدد کامل میباشد
//if (maghsoom.Sum() == n)
//{
//    Console.WriteLine("YES");
//}
//else if (maghsoom.Sum() != n)
//{
//    Console.WriteLine("NO");
//}

//****************************************************************************************
//int a = int.Parse(Console.ReadLine());
//int sum = 0;

//for (int i = 1; i < a; i++)
//{
//    if (a % i == 0)
//        sum += i;
//}

//// چون فقط و فقط یک کار قراره انجام بشه، در نتیجه آکولاداشو میتونیم نزاریم
//if (sum == a)
//    Console.WriteLine("YES");
//else
//    Console.WriteLine("NO");

//****************************************************************************************
//for (int i = 1; i < 11; i++)
//{
//    for (int j = 1; j < 11; j++)
//        Console.Write(i * j + " ");
//    Console.Write("\n");
//}

//****************************************************************************************
//// جدول ضرب جادویی
//for (int i = 1; i < 11; i++)
//{
//    for (int j = 1; j < 11; j++)
//        if (i == j)         // اگر شماره سطر و شماره ستون برابر باشند
//        {
//            Console.Write(0 + " ");
//        }
//        else if (i < j)     // شماره سطر کوچکتر از شماره ستون
//        {
//            Console.Write((-(i * j)) + " ");
//        }
//        else
//        {
//            Console.Write((i * j) + " ");       // شماره سطر بزرگتر از شماره ستون
//        }

//    Console.Write("\n");
//}

//****************************************************************************************
//// گرفتن ورودی از کاربر
//int n = int.Parse(Console.ReadLine());

//int totalsum = 1;           // تعریف متغیر جمع کل برای پایان برنامه

//int linesum = 1;            // تعریف متغیری برای جمع اعداد در هر خط

//string line = "1";          // نشان دادن استرینگی برای جمع هر عدد

//for (int i = 1; i < n + 1; i++)
//{   
//    if (i == 1)
//    {
//        Console.WriteLine($"{1} = {1}");
//    }
//    else
//    {
//        for (int j = i; j<=i; j++)
//        {
//            linesum += j;
//            line = line + "+" + j;
//            Console.WriteLine($"{line} = {linesum}");
//            totalsum += linesum;
//        }

//    }
//}
//Console.WriteLine($"Total sum of series is: {totalsum}");

//****************************************************************************************
//long n = long.Parse(Console.ReadLine());
//long sum = 0;

//while (n >= 10)
//{   
//    // جمع ارقام عدد n
//    while(n != 0)       
//    {
//        sum += n % 10;
//        n /= 10;
//    }

//    n = sum;
//    sum = 0;
//}
//Console.WriteLine(n);

//****************************************************************************************

//long n = long.Parse(Console.ReadLine());
//long sum = 0;

//while (true)
//{
//    // جمع ارقام عدد n
//    while (n != 0)
//    {
//        sum += n % 10;
//        n /= 10;
//    }

//    // چک میکنیم در صورتیکه مجموع مجددا بزرگتر مساوی 2 شد، برگرده به چرخه بالا
//    if (sum.ToString().Length >= 2)
//    {
//        n = sum;
//        sum = 0;
//        continue;
//    }
//    else
//    {
//        break;
//    }

//}
//Console.WriteLine(sum);

//****************************************************************************************
//int n, sum = 0;
//n = int.Parse(Console.ReadLine());
//while (sum >= 10)
//{
//    sum += (n % 10);
//    n = n / 10;
//}
//Console.WriteLine(sum);


//****************************************************************************************
//for (int i = 1, j = 2; i < 10 || j < 10; i += 2, j += 2)
//{
//    Console.WriteLine(i + " " + j);
//}

//****************************************************************************************
//Console.WriteLine("bal e pashe\r\nsooske abi\r\ntof e tak shakh\r\nrishe bid e majnoon\r\nkhak e ros e sad sale\r\nserke amme leyla\r\nmooy e khers");

//****************************************************************************************
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"aji maji la taraji {n}.\r\nman ghol midam dige taghallob nakonam.\r\nvagarna khoda mano soosk kone!");

//****************************************************************************************
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(n * 5);

//****************************************************************************************
//string[] input = Console.ReadLine().Split(' ');
//int a = int.Parse(input[0]);
//int b = int.Parse(input[1]);
//int c = int.Parse(input[2]);
//int d = int.Parse(input[3]);

//int sum = a + b + c;

//if (sum % d != 0)
//    Console.WriteLine("mituni");
//else
//    Console.WriteLine("nemituni");

//****************************************************************************************

