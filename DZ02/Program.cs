try
{
Console.WriteLine("Веддите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веддите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double r = dist (x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между точками равно {r}");

}
catch
{
    Console.WriteLine("Введите корректные координаты точек");
}
double dist (int x1,int y1,int z1,int x2,int y2,int z2)
{
double d = Math.Sqrt((x2-x1)*(x2-x1)*(z2-z1)+(y2-y1)*(y2-y1)*(z2-z1));
return d;
}










