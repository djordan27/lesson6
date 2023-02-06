using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())

*/

string getStringNumber()
{
    return Console.ReadLine();
}
int[] numberSplit(string number)
{
    string[] myArray = number.Split(',');
    int[] array = new int[myArray.Length];
    for (int i = 0; i < myArray.Length; i++)
    {
        array[i] = Convert.ToInt32(myArray[i]);
    }

    return array;
}

void printArray(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
}

int getPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

string lastNumber = getStringNumber();
int[] arrayOffNumbers = numberSplit(lastNumber);
printArray(arrayOffNumbers);
Console.WriteLine($"-> {getPositiveNumber(arrayOffNumbers)}");