int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {

            Console.WriteLine($"Вы ввели число: {number}");

            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число. \nВведите число ещё раз: ");
        }
    }
}

Console.Write("Введите число: ");

int cube = InNumber();

for(int i =1; i <= cube; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");

}