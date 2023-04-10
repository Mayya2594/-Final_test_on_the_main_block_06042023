// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray (int size)
{
    string[] userArr = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите значение строки: ");
        userArr[i] = Console.ReadLine()!;
    } 
    return userArr;
}

void PrintArray (string[] userArr)
{
    int size = userArr.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1) Console.Write($"'{userArr[i]}', ");
        else Console.Write($"'{userArr[i]}']");
    }
    Console.WriteLine();
}

int ResultArrLength (string[] userArr)
{
    int userSize = userArr.Length;
    int resultSize = 0;
    for(int i = 0; i < userSize; i++)
    {
        if(userArr[i].Length <= 3)
            resultSize++;
    }
    return resultSize;
}

string[] ResultArr (string[] userArr, int resultSize)
{
    int userSize = userArr.Length;
    string[] resultArr = new string[resultSize];
    int j = 0;
    for(int i = 0; i < userSize; i++)
    {
        if(userArr[i].Length <= 3)
        {
            resultArr[j] = userArr[i];
            j++;
        }
    }
    return resultArr;
}

Console.WriteLine("Введите количество строк массива:");
int num = int.Parse(Console.ReadLine()!);

string[] usermass = FillArray(num);
PrintArray(usermass);
int resultLength = ResultArrLength(usermass);
string[] resultMass = ResultArr(usermass, resultLength);
PrintArray(resultMass);