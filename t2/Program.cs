// Implicit Conversing for and Double
int myInt = 124561;
double myDouble = myInt;
Console.WriteLine(myDouble);
//-------------------------------------------------
// Implicit coversing Int to long
int myInt2 = 459894584;
long myLong =  myInt2;
Console.WriteLine(myLong);
//-------------------------------------------------
// Implicit coversing float to double
float myFloat = 123.123456789f;
double mydouble2 = myFloat;
Console.WriteLine(mydouble2);
//-------------------------------------------------
// (explicit conversing) casting double to int
int myInt3;
double myDouble3 = 546.89546331145;
myInt3 = (int)myDouble3;
Console.WriteLine(myInt3);
Console.ReadKey();
