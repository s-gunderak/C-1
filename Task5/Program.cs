// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
//  4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//  2 -> " -2, -1, 0, 1, 2" 

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Введите число болшее либо равное 0");
}
else
{
int count = -N;
while (count <= N)
{
    Console.Write(count + ", ");
    count ++;
}
}