/*
int [,] FillArray2d()
{
    Console.WriteLine(" Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());

    int [,] filled2Array = new int [userRows, userColumns];

    for (int i = 0; i < userRows; i++)
        for (int j = 0; j < userColumns; j++)
            filled2Array [i,j] = i + j;
    
    return filled2Array;
}

void show2DArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write (array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] secondTaskArray = FillArray2d();
show2DArray(secondTaskArray);
*/

/*
double [,] Creat2DArray (int row, int column, int minV, int maxV)
{
    double [,] created2DArray = new double [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        //int intDigit = new Random().Next(minV,maxV);
       // double doubleGidits = new Random().NextDouble();
       // created2DArray [i,j] = math.Round (intDigit + doubleDigits, 3 )
            created2DArray[i,j] = Math.Round((new Random().Next(minV,maxV)) + (new Random().NextDouble()), 2);

    return created2DArray;
}

void ShowDouble2DArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] Change2DArray (double [,] arrayToChange)
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
    {
        for ( int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            if ( i % 2 != 1 && j % 2 != 1)
               arrayToChange[i,j] = Math.Round(Math.Pow(arrayToChange[i,j], 2), 2);
        }
    }
    return arrayToChange;
}

Console.WriteLine(" Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

double [,] createdArray = Creat2DArray(userRows, userColumns, userMin, userMax);
ShowDouble2DArray(createdArray);
double [,] changedArray = Change2DArray(createdArray);
ShowDouble2DArray (changedArray);
*/

/*
//47
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

/*
//50
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
*/


/*
//52
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/