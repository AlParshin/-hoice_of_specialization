// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Метод для заполнения нашего массива
string[] FillArray(string[] array)
{
    Console.WriteLine("Заполните массив элементами:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент:");
        array[i] = Convert.ToString(Console.ReadLine());
        if (array[i].Length == 0) Console.WriteLine($"Внимание! Вы ввели {i}-й элемент пустым!");
    }
    return array;
}

// Метод для поиска элементов длиной меньше 3 симоволов и для добавления их в новый массив
string[] LessThanThree(string[] array)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newSize++;
    }
    string[] newArray = new string[newSize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

// Метод для распечатки нового массива
void PrintArray(string[] newArray)
{
    Console.WriteLine("А теперь распечатаем наш полученный массив строк:");
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(newArray[i]);
        }
        else
        {
            Console.Write($", {newArray[i]}");
        }
    }
    Console.Write("]");
}