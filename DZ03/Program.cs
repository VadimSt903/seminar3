Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cub){
  int coun = 0;
  int length = cub.Length;
  while (coun <  length){
    cub[coun] = Convert.ToInt32(Math.Pow(coun, 3));
    coun++;
  }
}

void PrintArry(int[] coll){
  int coun = coll.Length;
  int index = 0;
  while(index < coun){
    Console.WriteLine(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cub+1];
Cube(arry);
PrintArry(arry);




