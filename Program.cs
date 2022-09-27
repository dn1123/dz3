/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

string InNumber()
{
    while (true)
    {
        string = = Console.ReadLine();
        if (int.TryParse(text, out int ))
        {
            if (text.Length == 5)
            {
                Console.WriteLine($"Вы ввели число: {text}");

                return ;

                break;
            }
            else
            {
                Console.Write("Вы ввели не пятизначное число. \nВведите число ещё раз: ");
            }
        }
        else
        {
            Console.Write("Не удалось распознать число. \nВведите число ещё раз: ");
        }
    }
}

Console.Write("Введите пятизначное число: ");

string = = InNumber();

if (stringNumber[0] == stringNumber[4] || stringNumber[1] == stringNumber[3])
{
    Console.WriteLine($"Ваше число: {stringNumber} - палиндром.");
}
else Console.WriteLine($"Ваше число: {stringNumber} - НЕ палиндром.");