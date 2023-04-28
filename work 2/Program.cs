/*
//Console.Write ("Hi my friend");
Console.WriteLine ("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine (number);
*/

/*
// Задача 1.
// Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Write ("Add number:");
int numBer_1 = Convert.ToInt32(Console.ReadLine());

int result = numBer_1*numBer_1;

Console.WriteLine (numBer_1*numBer_1);
Console.WriteLine ("Your number is " + numBer_1 + ". Square of this number is " + result);
*/

//3
//Напишите программу,которая на вход принимает два числа и проверяет,
//является ли первое число квалратом второго.

// a =5, b =25 -> no
// a =25, b =5 -> yes
/*
1. запросить два значения (12+12 строки)
2. возвести второе число в квадрат
3. проверить на равенство первому квадрату

Console.WriteLine ("Input your 1st number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input your 2nd number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_2 * number_2 == number_1 )
{
    Console.WriteLine($"Your first number is a squer of the second one");
}
else
{
    Console.WriteLine($"Your first number is not a squer of the second one");
}
*/

/*
//5

Console.WriteLine ("Input your number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = number_N * (-1);

while (current_i <= number_N)
{
    Console.Write (current_i + " ");
    current_i ++; // current_1 += 1
}
*/

/*
//7

//1 вод числа 
//2 проверить его на значность (N >99 + N < 1000)
//3 найти последнюю цифру (%10)

Console.WriteLine ("Input your  number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000) 
{
    int dav = number % 10;
    Console.WriteLine("Last digit {number} is {dev}");
}
else
{
    Console.WriteLine("Yuer number is not 3-digit!");
}
*/

/*
//2

Console.WriteLine("5");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("7");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
 {
    Console.WriteLine("5" + num_A + "8" + num_B);
}
 else
{
     Console.WriteLine("7" + num_B + "6" + num_A);
}
*/

/*
//4

Console.WriteLine("первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("Максимальное из этих чисел = " + max);
*/

/*
//6

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
System.Console.WriteLine("Число: " + a + " четное");
else System.Console.WriteLine($"Число: {a} нечетное");
*/

/*
//8

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}
*/