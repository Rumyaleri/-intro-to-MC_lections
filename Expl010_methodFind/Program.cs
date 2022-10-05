int[] array = {11, 12, 13, 14, 15, 16, 17, 13, 18};

int n = array.Length;
// задаем переменную n - длина массива

int find = 13;
// задаем искомое значение через переменную find

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;
    // если в массиве несколько одинаковых значений  и если нам надо найти только 1 индекс то break прервет цикл после первого найденного индекса
    }
    index++;
}