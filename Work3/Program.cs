// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//ввод элеменетов через консоль (через запятую. использовать метод string.Split())
Console.WriteLine("Введите последобательно 8 любых чисел, через запятую, без пробелов");
int [] array = new int[8]; 
string [] arrayNum = Console.ReadLine().Split(',');
Console.WriteLine("Получившийся массив :");
for(int i = 0; i < array.Length; i++)
{
   array[i] = int.Parse(arrayNum[i]);
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write ($"{array[i]} ");
}