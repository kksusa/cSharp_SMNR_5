double[] Array(int N)
{
    Random rndm = new Random();
    double [] array = new double[N];
    Console.Write("[");
    for (int i = 0;i < array.Length;i++)
    {
        array[i] = Math.Round(rndm.NextDouble() * 200 - 100, 2);
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }    
    return array;
}

void DiffMaxMinInArray(double [] array)
{
    int i = 1; 
    double max = array[0];
    double min = array[0];
    for (;i < array.Length;i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }    
        Console.WriteLine("Разница между максимальным и минимальным элементами в массиве с диапазоном от -100 до 100 равна " + Math.Round(max - min, 2) + ".");
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
            double[] array = Array(numberOfElements);
            Console.WriteLine();
            DiffMaxMinInArray(array);
            check1 = false;
        }    
    }
    else Console.WriteLine("Число введено неправильно.");
}