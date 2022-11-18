// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Please enter day number: ");

int number;

while (true)
{
    if(int.TryParse(Console.ReadLine(), out number))
        break;  
    Console.WriteLine("Input error!!!");
}

Convert.ToInt32(number);

if (number < 6)
{
    Console.WriteLine($"{number} -> нет");
}
if (number == 6)
{
    Console.WriteLine($"{number} -> да");
}
if (number == 7)
{
    Console.WriteLine($"{number} -> да");
}
if (number > 7)
{
    Console.WriteLine($"{number} -> несуществующий день недели");
}
