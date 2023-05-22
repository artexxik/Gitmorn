// задание 1
/*
void MetFindSun (int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
    {
        sum += current;
    }
    Console.WriteLine($"Summ of elements from 1 to {a} is {sum}");  
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num >= 1)
{
    MetFindSun(user_num);
}
else 
    Console.WriteLine("impossible val");
*/
//homework
/*
//25
int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
  */

/*
  //27
  Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

//29
