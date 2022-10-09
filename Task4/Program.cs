/* Напишите программу, которая принимает на вход число N и выдает таблицу квадратов от 1 до N.
*/
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) )
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");

    }
    return result;
}

void GetNumb (int number)
{
    Console.Write($"{number} ->");
    for (int i = 1; i <= number; i++) 
    {
        double square = Math.Pow(i,2);
        Console.WriteLine($" {square},");
    }
}
Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
GetNumb (numb);