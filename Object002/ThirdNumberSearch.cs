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
else 
    Convert.ToInt32(numberBig);
    string digit = Convert.ToString(numberBig);
    Console.WriteLine($"{numberBig} -> {digit[2]}");

  