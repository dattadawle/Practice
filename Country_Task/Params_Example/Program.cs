void printNumbers(params int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write(number+ " ");
    }
    Console.WriteLine();
}

printNumbers(1,2,3,4,5);
printNumbers(2,3,4,6,7);