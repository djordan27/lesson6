// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getNumber(){
    return Convert.ToDouble(Console.ReadLine());
}
void findDot(){
    Console.WriteLine("пожалуйста введите k1: ");
    double k1 = getNumber();
    Console.WriteLine("пожалуйста введите k2: ");
    double k2 = getNumber();
    Console.WriteLine("пожалуйста введите b1: ");
    double b1 = getNumber();
    Console.WriteLine("пожалуйста введите b2: ");
    double b2 = getNumber();
    double result1 = (b2 - b1)/(k1 - k2);
    double result2 = k1 * result1 + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({result1}; {result2})");
}

findDot();