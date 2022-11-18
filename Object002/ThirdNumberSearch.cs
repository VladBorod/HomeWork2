// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Please enter the number: ");

int numberBig;

while (true)
{
    if(int.TryParse(Console.ReadLine(), out numberBig))
        break;  
    Console.WriteLine("Input error");
}
if (numberBig / 100 == 0)
    Console.WriteLine($"{numberBig} -> третьей цифры нет.");

int numberThreeGrade = 0;
int numberCheck = numberBig;

if (numberCheck >= 100);
    {
        while (numberCheck > 999)
            numberCheck = numberCheck / 10;
    }
    numberThreeGrade = numberCheck % 10;

Console.WriteLine($"{numberBig} -> {numberThreeGrade}");  