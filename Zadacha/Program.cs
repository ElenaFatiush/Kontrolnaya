Kontrolnaya();

void Kontrolnaya()
{
    //Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна
    //3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
    //При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    int n = 3;
    int size = 5;
    string[] array = new string[size];
    Console.WriteLine($"Введите элементы строк {size} раз через Enter для создания массива");
    FillArray(array);
    Console.Clear();
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("------------");
    if (GetSizeSecondArray(array) == 0)
    {
        Console.WriteLine("По введенным данным невозможно выполнить задачу. Введите новые значения.");
    }
    else
    {
        string[] arrayNew = Transfer(array);
        Console.WriteLine($"Новый массив, содержащий строки длиной меньше или равной {n}");
        PrintArray(arrayNew);
        Console.WriteLine();
        Console.WriteLine("------------");
    }

    void FillArray(string[] arr)
    {
        for (int i = 0; i < size; i++)
        {
            arr[i] = Console.ReadLine();
        }
    }

    void PrintArray(string[] arr)
    {
        int arrLeng = arr.Length;
        Console.Write("[ ");
        for (int i = 0; i < arrLeng; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.Write("]");
    }

    int GetSizeSecondArray(string[] arr)
    {
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i].Length <= n) count++;
        }
        return count;
    }

    string[] Transfer(string[] arr)
    {
        string[] arrayNew = new string[GetSizeSecondArray(array)];
        for (int i = 0, j = 0; i < size; i++)
        {
            if (arr[i].Length <= n)
            {
                arrayNew[j] = arr[i];
                j++;
            }
        }
        return arrayNew;
    }

}


