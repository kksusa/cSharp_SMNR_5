int[] Array(int N)
{
    Random rndm = new Random();
    int [] array = new int[N];
    Console.Write("[");
    for (int i = 0;i < array.Length;i++)
    {
        array[i] = rndm.Next(-100,101);
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }    
    return array;
}

void OddPositionNumbersSumInArray(int [] array)
{
    int sum = 0;
    for (int i = 0;i < array.Length;i += 2)
    {
        sum += array[i];
    }   
    Console.WriteLine("Сумма элементов с нечётными позициями в массиве с диапазоном от -100 до 100 равна " + sum + ".");
}

bool check1 = true;
while (check1)
{
    Console.WriteLine("Введите число элементов в массиве:");
    if (int.TryParse(Console.ReadLine()!, out int numberOfElements))
    {
        if (numberOfElements <= 0) Console.WriteLine("Число введено неправильно.");
        else
        {
            int[] array = Array(numberOfElements);
            Console.WriteLine();
            OddPositionNumbersSumInArray(array);
            check1 = false;
        }    
    }
    else Console.WriteLine("Число введено неправильно.");
}