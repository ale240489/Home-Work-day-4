//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SummOfNumber(int a)
{
    string sum = a.ToString();
    int summa = 0;
    for(int i = 0; i < sum.Length; i++)
    {
        summa = summa + int.Parse(sum[i].ToString());
    }
    return summa;
}

int y = GetNumber();
Console.WriteLine ($"Сумма цифр в числе {y} = {SummOfNumber(y)}");
