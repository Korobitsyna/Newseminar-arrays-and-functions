/* Напишите программу, которая на вход принимает координаты точки (X и Y), причем X не равно 0 и Y не равно 0 
и выдает номер четверти в плоскости, где находится эта точка.
*/

// получает координату не равную 0

int GetCoordinate(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");

    }
    return result;
}

// поулчает четверть, в которой лежит точка (х, у)

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetCoordinate("Введите координату X не равную 0");
int y = GetCoordinate("Введите координату y не равную 0");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти");