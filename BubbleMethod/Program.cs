class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива (целые числа через пробел):");

        // Вводим строку и разбиваем по пробелам
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');

        // Преобразуем строковый массив в массив целых чисел
        int n = stringArray.Length;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }

        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Меняем элементы местами
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}