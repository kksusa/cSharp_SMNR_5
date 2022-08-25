int[] Array(int N)
{
    Random rndm = new Random();
    int [] array = new int[N];
    Console.Write("[");
    for (int i = 0;i < array.Length;i++)
    {
        array[i] = rndm.Next(100,1000);
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }    
    return array;
}

void HonestNumbersInArray(int [] array)
{
    int count = 0;
    for (int i = 0;i < array.Length;i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }    
    Console.WriteLine("Число чётных элементов в массиве равно " + count + ".");
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
            HonestNumbersInArray(array);
            check1 = false;
        }    
    }
    else Console.WriteLine("Число введено неправильно.");
}