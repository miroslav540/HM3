int [] array ()    // сделал усложненую версию
{
    Console.WriteLine("Введите количество цифр");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] result = new int [num];
    for (int i = 0; i < num; i++) // если сделать <= то получается ошибка, надо посмотреть почему
    {
        int A = (new Random()).Next(0,100); // решил от 0 до 100
        result[i] = A;
        Console.Write(result[i] + " ");    
    }

    return result;
}

array();

//не обращайте внимание на заметки, это я для себя ^_^