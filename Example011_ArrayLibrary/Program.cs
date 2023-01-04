void FillArray(int[] collection) //Создание собственного метода
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) //void метод который не возвращает значения,в коде не используем return
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //метод находит индекс искомого числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Если искомого элемента нет то метод выведет -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //завершает метод на 1 совпадении с искомым числом
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //new int[10] дословно создай новый массив в котором будет 10 элементов

FillArray(array); //Запуск метода который заполнил массив
PrintArray(array); //Запуск метода который напечатал массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);