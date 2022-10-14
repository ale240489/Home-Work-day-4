// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNumber (string message)
{
    Console.WriteLine(message);
    string num = Console.ReadLine(); 
    int number = int.Parse(num);
    return number;
}


int a = GetNumber("Введите число А");
int b = GetNumber("Введите число B");
Console.WriteLine($"Вы ввели число A = {a} и число B = {b}");
 Console.WriteLine ($"Число {a} в степени {b} = {Math.Pow(a, b)}");


