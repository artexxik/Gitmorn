
// 1
/*
void Digit1 (int number)
{
    int ed = number % 10;
    int dec = number / 10;
    if (ed > dec)
    {
        Console.WriteLine ("Thee biggest digit is " + ed);
    }
    else
    {
        Console.WriteLine (" The biggest digit is " + dec);
    }
}
/*
Console.WriteLine("imput number: ");
int user_namber = Convert.ToInt32(Console.ReadLine());

if (user_namber > 9 && user_namber < 100)
{
    int res = Digits (user_namber);
    Console.WriteLine($"The biggest digit is {res}");
}
 else
 {
    Console.WriteLine("impossible value! ");
 }
 

//1 невозвратный метод без аргумента
//2 генератор

void MAxDigit ()
{
    int randomNum =new Random().Next(10, 100);
    Console.WriteLine("Your number is " + randomNum);

    Digit1 (randomNum);

}

MAxDigit();
*/
/*
//3

void Cratnost (int a, int b, int num)
{
    if (num % a == 0 && num % b == 0)
    {
        Console.WriteLine($" your number {num}  is multiple of {a} and {b}");

    }
    else
    {
        Console.WriteLine($" your number {num}  is not multiple of {a} and {b}");

    }
}

// запрос данных у пользователя
Console.WriteLine("Enter your number: ");
int new_user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your 1 devider: ");
int dev1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your 2 devider: ");
int dev2 = Convert.ToInt32(Console.ReadLine());

Cratnost(dev1, dev2, new_user_num);
*/

/*
//4
int DeletDec()
{
    int randomNumder = new Random().Next(100, 1000);
    Console.WriteLine("Your number is" + randomNumder);

    int digit1 = randomNumder / 100;
    int digit2 = randomNumder % 10;

    int new_num = digit1 * 10 + digit2;
    return new_num;
}
int r = DeletDec();
Console.WriteLine($"Your number is {r}");
*/

/*
//homewprk
//10

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
*/
/*
//13
Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/

/*
//15
int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("number");
string ss = "it's not a day of the week";
string check(int number)
{
if (number >= 6 && number < 8) ss = "it's a holiday";
if (number >= 1 && number < 7) ss = "it's a weekday";
return ss;
}
System.Console.WriteLine(check(number));
*/