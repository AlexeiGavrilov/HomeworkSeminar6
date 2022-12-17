//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.Не использовать массив.
//M=5 ; 0, 7, 8, -2, -2 -> 2
//M=5 ; -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Какое количество чисел будете вводить?");
int z = Convert.ToInt32(Console.ReadLine());
int count =0;
for(int i=1, j=0; i <= z; i++,j++)
{
    Console.WriteLine($"Введите {i} число:");
    j = Convert.ToInt32(Console.ReadLine());
    if(j>0)
    {
        count+=1;
    }
}
Console.WriteLine();
Console.WriteLine("Чисел, которые больше 0 => " +count);