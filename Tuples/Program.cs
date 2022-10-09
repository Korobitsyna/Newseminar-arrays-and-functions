// кортежи

int Max(int [] array)
{
    int max = array[0];
for (int i = 1; i < array.length; i++)
{
    if(array[i] > max)
    max = array[i];
}
return max;
}

int Min(int [] array)
{
    int min = array[0];
for (int i = 1; i < array.length; i++)
{
    if(array[i] < min)
    min = array[i];
}
return min;
}


// первым возвращается max вторым min
(int, int) FindMaxAndMin(int []array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.length; i++)
{
    if(array[i] > max)
    max = array[i];
   
    if(array[i] < min)
    min = array[i];
}

return(max, min);

// void, int, string, bool, random, кастомные классы из разных библиотек

int [] array = new int[10];

(int max, int min) = FindMaxAndMin;

if(max > min)
Console.WriteLine($"{max}, {min} Макс больше мин");