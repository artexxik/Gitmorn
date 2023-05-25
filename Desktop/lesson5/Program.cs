/*
int [] CreateRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void showArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1+ " ");
    Console.WriteLine();
}

int FindSummNegativeElem (int [] array)
{
    int sumNegative = 0;
    for ( int i = 0; i < array.Length; i++)
        if (array[i] < 0)
           sumNegative += array[i];
    return sumNegative;
}

int FindSummPositiveElem (int [] array)
{
    int sumPositive = 0;
    for ( int i = 0; i < array.Length; i++)
        if (array[i] > 0)
           sumPositive += array[i];
    return sumPositive;
}

int sizeArray = 12;
int minValue = -9;
int maxValue = 9;

int [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
showArray(createdArray);
Console.WriteLine($"Summ of positive elements is {FindSummPositiveElem(createdArray)}");
int resultNegative = FindSummNegativeElem(createdArray);
Console.WriteLine($"Summ of negative elements is {resultNegative}");
*/

//homework
//34
/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + "");
}

}

int kol(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

mas(a);
Console.Write($"\nКоличество чётных чисел в массиве: {kol(randomArray)}");
*/

//36

/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + "");
}

}

int kol(int[] randomArray)
{
int sum = 0;
int i = 0;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

mas(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");
*/

//38


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2} ");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");