// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Если кол-во элементов нечетное, то элемент посередине не учитывать.Результат сложения вывести на экран.
void FillArrayRandNum(int [] arr, int len)
{

  for(int z = 0; z < len; z++)
  {
    arr[z] = new Random().Next(1,50);
  }
  
}

void PrintArray(int [] arr1, int len1)
{
    for(int h =0; h < len1; h++)
    {
        Console.Write(arr1[h] + " ");
    }
}


Random rnd = new Random();
int N = rnd.Next(4,14);
int [] array = new int [N];
FillArrayRandNum(array, array.Length);
PrintArray(array, array.Length);
Console.WriteLine();
int sum = 0;
for(int i = 0,j = array.Length-1; i < array.Length/2; i++,j--)
{
    sum = sum + (array[i]*array[j]);
    
}
Console.WriteLine(sum);
