/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
*/

int GetCoordinate(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0 && result <= 4)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");

    }
    return result;
}

void GetDistanceBetweenTwoPoints(int firstx, int firsty, int secondx, int secondy)
{
double result = 0;
double tempx = Math.Pow(secondx - firstx, 2);
double tempy = Math.Pow(secondy-firsty, 2);
result = Math.Sqrt(tempx + tempy);

Console.WriteLine($"Расстояние между двумя точками равно {result} ");
}

GetDistanceBetweenTwoPoints(7, 1, -5, -1);

