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

        if (int.TryParse(Console.ReadLine(), out result) )
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
 Console.WriteLine($"Расстояние между точками равно {result}");
}

int firstx = GetCoordinate("Введите координату X первой точки");
int firsty = GetCoordinate("Введите координату y первой точки");
int secondx = GetCoordinate("Введите координату X первой точки");
int secondy = GetCoordinate("Введите координату y первой точки");
GetDistanceBetweenTwoPoints(firstx, firsty, secondx, secondy);



