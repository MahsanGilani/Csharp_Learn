
//char ch = 'a';
//Console.WriteLine((int)ch);

//********************************************************
//int asciiiCode = 100;
//Console.WriteLine((char)asciiiCode);

//********************************************************
//char input = char.Parse(Console.ReadLine());
//Console.WriteLine((int)input-96);

//********************************************************
//char ch;
//ch = Console.ReadLine()[0];
//Console.WriteLine((int)ch - (int)'a' + 1);

//********************************************************
//char x = char.Parse(Console.ReadLine());
//char y = char.Parse(Console.ReadLine());

//Console.WriteLine((int)y - (int)x);
///*This line
// is a comment*/

//********************************************************
//const int num = 10;
//Console.WriteLine(num);

//********************************************************
//Console.WriteLine("Hello\\World");
//Console.WriteLine("Hello\nWorld");
//Console.WriteLine("Hello\tWorld");
//Console.WriteLine("Hello\'\'World");
//Console.WriteLine("Hello\"salam\"World");

//********************************************************
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"Hello CodeCup {n}!");

//********************************************************
//Console.WriteLine("Bebakhshid, vali shoma nemitoonin too in mosabeghe sherkat konin :(");

//********************************************************
//string[] input = Console.ReadLine().Split(' ');
//int raasSheep = int.Parse(input[0]);
//float pashm = float.Parse(input[1]);
//int gheymat  = int.Parse(input[2]);

//Console.WriteLine((int)(raasSheep * pashm * gheymat));

//********************************************************
//int x = 3;
//int y = 2;
//Console.WriteLine(x * 2 + 3 * y * x - 4 % 3);

//********************************************************
//string[] input = Console.ReadLine().Split();
//int n = int.Parse(input[0])*100;
//int m  = int.Parse(input[1])*100;
//Console.WriteLine(n*m/20);

//********************************************************
//string[] input = Console.ReadLine().Split();
//int shah = int.Parse(input[0]);
//int vazir = int.Parse(input[1]);
//int rokh = int.Parse(input[2]);
//int phil = int.Parse(input[3]);
//int asb = int.Parse(input[4]);
//int sarbaz = int.Parse(input[5]);
//Console.Write($"{1 - shah} {1 - vazir} {2 - rokh} {2 - phil} {2 - asb} {8 - sarbaz}");

//********************************************************
//int a = 1 + 2;
//int b = 5 - 3;
//Console.WriteLine("a = " + a + "    b = " + b);
//int c = a * 2;
//int d = c / 2;
//Console.WriteLine("a = " + a + "    c = " + c + "    d = " + d);
//int s = 4;
//int t = 12;
//Console.WriteLine("s + t = " + (s + t) + "    s * 3 = " + (s * 3) + "    4 * t = " + (4 * t));
//int x = 2;
//x++;
//Console.WriteLine("x = " + x);
//x--;
//Console.WriteLine("x = " + x);

//********************************************************
//Console.WriteLine("2 / 3 = " + (2 / 3));
//Console.WriteLine("2.0 / 3 = " + (2.0 / 3));
//Console.WriteLine("2 / 3.0 = " + (2 / 3.0));
//Console.WriteLine("2.0 / 3.0 = " + (2.0 / 3.0));

//********************************************************
//int a = 4;
//int b = 5;

//Console.WriteLine("a * 1.0 / b = " + (a * 1.0 / b));
//Console.WriteLine("a / (b * 1.0) = " + (a / (b * 1.0)));
//Console.WriteLine("float(a) / b = " + ((float)a / b));
//Console.WriteLine("a / float(b) = " + (a / (float)b));
//Console.WriteLine("------ These have different meaning! ------");
//Console.WriteLine("float(a / b) = " + ((float)(a / b)));
//Console.WriteLine("a / b * 1.0 = " + (a / b * 1.0));

//********************************************************
//int n = int.Parse(Console.ReadLine());
//int output = n % 10;
//Console.WriteLine(output);

//********************************************************
//int input = int.Parse(Console.ReadLine());
//int hour = input / 3600;
//int baghiHour = input % 3600;
//int minute = baghiHour / 60;
//int second = baghiHour % 60;
//Console.WriteLine($"{hour} : {minute} : {second}");

//********************************************************
//string[] input = Console.ReadLine().Split(' ');
//int hourShomar = (12 - int.Parse(input[0]))%12;       // برای دیدن ساعت در آینه باید منهای 12 کنیمش         همچنین برای اینکه توی محدوده 12 بمونیم از باقیمانده استفاده میکنیم که عددمون جلوتر نره
//int minuteShomar = (60 - int.Parse(input[1]))%60;      // برای دیدن دقیقه در آینه باید منهای 60 کنیمش

//Console.WriteLine(hourShomar.ToString("00") + ":" + minuteShomar.ToString("00"));

//********************************************************
//int input = int.Parse(Console.ReadLine());
//int input2 = input % 100;   // برای اطمینان از اینکه عددمون زیر 100 هستش و دو رقمیه
//int yekan = input2 % 10;   // رقم یکان
//int sadgan = input2 / 10;     // خارج قسمت
//Console.WriteLine(yekan + sadgan);

//********************************************************
//int a = 4;
//int b = 7;
//a += 9;
//b -= 2;
//a %= b;
//Console.WriteLine(a + " " + b);

//********************************************************
//int x = 4 * 2;
//int y = 3 * 3 - 1;
//Console.WriteLine((x + y) / (x - y));     //RunTime Error

//********************************************************
//int a = 2;
//int b = 3;
//Console.WriteLine((a | b) + " " + (a & b) + " " + (a ^ b));

//********************************************************
//int x = 5;
//int y;

////y = x++;
////y = ++x;
////y = x--;
//y = --x;
//Console.WriteLine(x + " " + y);

//********************************************************
//string[] input = Console.ReadLine().Split(' ');
//int S = int.Parse(input[0]);
//int W = int.Parse(input[1]);
//int I = int.Parse(input[2]);
//// S + W + R = 24h
//// S + W <= 24;
//// I <= S , W        زمان مشترک کار و درس
////10 11 2
//Console.WriteLine( 24 - (S + W - I) );

//********************************************************
//int k = int.Parse(Console.ReadLine());
//int Tedad = (0 + k) + 1;        // تعداد اعداد متوالی
//int sum = ((0 + k) * Tedad) / 2;    // مجموع اعداد متوالی
//Console.WriteLine(sum);

//********************************************************
//int a1 = int.Parse(Console.ReadLine());
//int b1 = int.Parse(Console.ReadLine());
//int a2 = int.Parse(Console.ReadLine());
//int b2 = int.Parse(Console.ReadLine());
//int a3 = int.Parse(Console.ReadLine());
//int b3 = int.Parse(Console.ReadLine());

//int min1 = Math.Min(a1, b1);
//int min2  = Math.Min(a2, b2);
//int min3 = Math.Min(a3, b3);

//Console.WriteLine(min1 + min2 + min3);

//********************************************************
//int n = int.Parse(Console.ReadLine());
//if (n % 2 == 0)
//{
//    int m = (n / 2);
//    Console.WriteLine((m+1)*(m+1));
//}
//else
//{
//    int t = (n / 2);
//    int k = (n / 2) + 1;
//    Console.WriteLine((t+1)*(k+1));
//}

//********************************************************
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//int[] salam = new int[] { a, b, c, d };
//int maxAB = Math.Max(a, b);
//int maxCD = Math.Max(c, d);
//int maxKol = Math.Max(maxAB, maxCD);

//int minAB = Math.Min(a, b);
//int minCD = Math.Min(c, d);
//int minKol = Math.Min(minAB, minCD);

//string Sum = (a + b + c + d).ToString("F6");
//string Average = ((a + b + c + d) / 4.0).ToString("F6");
//string Product = (a * b * c * d).ToString("F6");
//string max = maxKol.ToString("F6");
//string min = minKol.ToString("F6");


//Console.WriteLine($"Sum : {Sum}");
//Console.WriteLine($"Average : {Average}");
//Console.WriteLine($"Product : {Product}");
//Console.WriteLine($"MAX : {max}");
//Console.WriteLine($"MIN : {min}");

//********************************************************