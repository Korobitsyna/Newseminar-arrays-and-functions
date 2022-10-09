/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x, y).
*/
int GetQuarter(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0 && result <= 4)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидный номер четверти!\n");

    }
    return result;
}

void NumberOfQuarter(int numb)
{
    if(numb==1)
    Console.WriteLine("X от 0 до + бесконечность, Y от 0 до + бесконечность");
else if(numb==2)
    Console.WriteLine("X от 0 до - бесконечность, Y от 0 до + бесконечность");
    else if(numb==3)
    Console.WriteLine("X от 0 до - бесконечность, Y от 0 до - бесконечность");
    else
    Console.WriteLine("X от 0 до + бесконечность, Y от 0 до - бесконечность");
}

int x = GetQuarter("Введите номер четверти");

NumberOfQuarter(x);
