void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) arr[i] = 0;
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

ZeroEvenElements(array);
PrintArray(array);

// Создание объекта
// Random rnd = new Random ();
// В объектах есть методы, например, Next
// int value = rnd.Next(1,10); верхняя граница не включается


// ввод числовых данных с консоли
// string input = Colsole.RealLine(); ReadLine имеет строковый тип данных
// если нужно ввести числовые значения, то нужно преобразовать: int value = Convert.ToInt32(input);