/*
//19
int num,r,sum=0,t;
Console.Write("пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r=num % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("пятизначное число!");
*/

/*
//21
Console.WriteLine("\n Задача 21");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/

/*
//23
Console.WriteLine("\n Задача 23");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/