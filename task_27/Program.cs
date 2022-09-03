// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int counter = Convert.ToString(A).Length;
int advence = 0;
int result = 0;
for (int i = 0; i < counter; i++)
{
    advence = A - A % 10;
    result = result + (A - advence);
    A = A /10;
}
Console.WriteLine(result);

