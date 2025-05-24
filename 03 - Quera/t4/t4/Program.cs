//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine($"{i}- Hello Quera College");
//}
//***************************************************************

//for (int i = 10; i < 15; i++)
//{
//    Console.WriteLine(i * 3);
//}
//***************************************************************

//for (int i = 1; i < 102; i++)
//    Console.WriteLine(i + 99);
//***************************************************************

//for (int i = 100; i < 201; i++)
//    Console.WriteLine(i);
//***************************************************************

//for (int i = 10; i < 100; i += 2)
//{
//    Console.WriteLine(i);
//}
//***************************************************************

//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i <= n; i++)
//{
//    Console.WriteLine($"{i}- Hello Quera College");
//}

//***************************************************************

//int n = int.Parse(Console.ReadLine());

//Console.Write("W");
//for (int i = 0; i<n; i++)
//{   
//    Console.Write($"o");
//}
//Console.Write("w!");

//***************************************************************

//int n = int.Parse(Console.ReadLine());
//int factoial = 1;

//for (int i = 1; i <= n; i++)
//{
//    factoial = factoial * i;
//    //Console.WriteLine(factoial);
//}
//Console.WriteLine(factoial);

//***************************************************************
//string[] input = Console.ReadLine().Split(' ');
//int n = int.Parse(input[0]);
//int m = int.Parse(input[1]);

//for (int i=n+1; i<m ; i++)
//{
//    if ((i % 2 == 1) || (i % 2 == -1))
//    {
//        Console.Write(i + " ");
//    }
//}

//***************************************************************
//int n = 1;
//while (n < 100)
//{
//    Console.WriteLine($"{n}- Hello Quera College");
//    n++;
//}

//***************************************************************
//for (int i=1; i < 100; i++)
//{
//    Console.WriteLine($"{i}- Hello Quera College");
//}

//***************************************************************
//int password = 0;
//int correctPassword = 7891454;
//while (password != correctPassword)
//{
//    Console.WriteLine("Please enter your password: ");
//    password = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Hey!!!\n\t***Congrates***\nYou Wiiiin.");

//***************************************************************
//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//        break;
//    Console.Write(i + " ");
//}

//***************************************************************
//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//        continue;
//    Console.Write(i + " ");
//}

//***************************************************************
//int n = 85;
//int sum = 0;
//while (n != 0)
//{
//    n = int.Parse(Console.ReadLine());
//    sum += n;
//}
//Console.WriteLine(sum);

//***************************************************************
//int bijan = 0;
//int behrouz  = 0;
//int mohsen  = 0;

//int a = 0;
//int b = 0;
//int c = 0;

//while (true)
//{
//    string[] input = Console.ReadLine().Split(' ');
//    a = int.Parse(input[0]);
//    b = int.Parse(input[1]);
//    c = int.Parse(input[2]);
//    if (a < b && a < c)
//    {
//        bijan += 1;
//    }
//    else if (b < c && b < a)
//    {
//        behrouz += 1;
//    }
//    else if (c < a && c < b)
//    {
//        mohsen += 1;
//    }
//    else if ((a == b) && (a < c))
//    {
//        continue;
//    }
//    else if ((a == c) && (a < b))
//    {
//        continue;
//    }
//    else if ((a == b) && (b == c))
//    {
//        break;
//    }
//}


//if ( (bijan > mohsen) && (bijan > behrouz))
//{
//    Console.WriteLine("Eyval Bijan!");
//    //Console.WriteLine(bijan);
//}
//else
//{
//    Console.WriteLine("Ey baba! Eshkal nadare.");
//    //Console.WriteLine(bijan + " " + behrouz + " " + mohsen);
//}

//***************************************************************
//string input = Console.ReadLine();
//// استرینگ بالارو تبدیل به کاراکتر در یک لیست میکنیم
//char[] n = input.ToCharArray();
//// حالا ترتیب کاراکترهارو تغییر میدیم
//Array.Reverse(n);
//// تبدیل کاراکترها به استرینگ
//string m = new string(n);
////int mm = int.Parse(m);    //اگه تبدیل به عدد هم بکنیم، خود بخود صفرهای قبل عدد حذف میشوند.
////Console.WriteLine(mm);
//Console.WriteLine(m.TrimStart('0'));     //حذف صفرهای قبل از عدد

//***************************************************************
//long n = long.Parse(Console.ReadLine());
//long m = 0;
//while (n > 0)
//{
//    m = m * 10 + n % 10;
//    n /= 10;
//}
//Console.WriteLine(m);

//***************************************************************
string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
