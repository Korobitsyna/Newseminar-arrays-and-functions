/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
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

void GetDistanceBetweenTwoPoints(int firstx, int firsty, int firstz,  int secondx, int secondy, int secondz)
{
double result = 0;
double tempx = Math.Pow(secondx - firstx, 2);
double tempy = Math.Pow(secondy-firsty, 2);
double tempz = Math.Pow(secondz-firstz, 2);
result = Math.Sqrt(tempx + tempy + tempz);
 Console.WriteLine($"Расстояние между точками равно {result}");
}

int firstx = GetCoordinate("Введите координату X первой точки");
int firsty = GetCoordinate("Введите координату y первой точки");
int firstz = GetCoordinate("Введите координату z первой точки");
int secondx = GetCoordinate("Введите координату X второй точки");
int secondy = GetCoordinate("Введите координату y второй точки");
int secondz = GetCoordinate("Введите координату z второй точки");
GetDistanceBetweenTwoPoints(firstx, firsty, firstz, secondx, secondy, secondz);



