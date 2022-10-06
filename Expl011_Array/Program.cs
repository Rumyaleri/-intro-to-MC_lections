
int[] array = new int[10];
// new int[10] - создай новый массив в котором будет 10 элементов, 
//по умолчанию он будет наполнен нулями, поэтому нам нужен метод, который заполнит массив числами


// метод, который заполняет массив случайными числами
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    // вводим переменную - длина массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //аргумент collection  положить в коллекцию новое случайное число из диапазона от 1 до 10
        index++;
    }
}

//метод, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    // Если введенное число отсутстствует в массиве, то результат покажет -1 (тк если поставить 0, то результат будет 0, что не совсем верно, т.к. )
    // в массиве под индексом 0 есть елемент с отличным значением
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


// тестируем методы
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);





