// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine($"Please enter three-digit number");

int numberTD;

while (true)
{
    Console.Write("Enter three-digit number: ");
    if(int.TryParse(Console.ReadLine(), out numberTD))
        break;
    Console.WriteLine("Input error!");
}
// Console.WriteLine($"Are you shure it's a three-digit number? -> {numberTD}");

int numberSecondThird = numberTD % 100;
int numberSecond = numberSecondThird / 10;

Console.WriteLine($"{numberTD} -> {numberSecond}"); 

