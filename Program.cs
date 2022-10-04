// Задача 1*. Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную

Console.Clear();
Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine()!);

string binNum = new string("");
int index = 0;
Console.Write($"{number} = ");
binNum = Converter(number, binNum, index);
string[] arrayBinNum = binNum.Split(" ");

for (int i = arrayBinNum.Length - 1; i >= 0; i--) Console.Write($"{arrayBinNum[i]}");

string Converter (int number, string binNum, int index)
{
    if (number > 1) 
    {
        if (number % 2 == 0) 
        {
            binNum = binNum + 0 + " ";
            index++;
            return Converter(number/2, binNum, index);
        }
        else return Converter(number/2, binNum + 1 + " ", index);
    }
    else 
    {
        binNum = binNum + 1;
        return binNum;
    }
}