static void summaArray(string[] args)
{
    int n;
    Console.WriteLine("Введите размер массива");
    n = int.Parse(Console.ReadLine());
    int[] massiv = new int[n];
    Console.WriteLine("Введите элементы массива: "); //тут вводить по очереди
    for (int i = 0; i < n; i++)
    {
        massiv[i] = int.Parse(Console.ReadLine());
    }
    int Sum = 0;
    for (int i = 0; i < n; i++)
    {
       Sum+=massiv[i];
    }
    Console.WriteLine("Сумма="+Sum);
}
summaArray(args);
/* по заданию 452 -> 11
82 -> 10
9012 -> 12, но можно любые
*/