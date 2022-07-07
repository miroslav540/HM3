void mathpoww(double A, double B)
{
    double Sum = 0;
    for (double i = 0; i < A; i++)
    {
        Sum = Math.Pow(A, B);
    }
    Console.WriteLine(Sum);
}
mathpoww(3,5);
mathpoww(2,4);