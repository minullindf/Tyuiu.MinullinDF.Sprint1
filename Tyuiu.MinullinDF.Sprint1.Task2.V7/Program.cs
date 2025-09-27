using Tyuiu.MinullinDF.Sprint1.Task2.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string zv = new string('*', 75);

        Console.Title = "Спринт #1 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: выполняет указанные расчёты и печатает результат на экране        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);

        int r;
        Console.WriteLine("Введите значение радиуса:");
        r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        Console.WriteLine(ds.CalculateSquareCircle(r));

        Console.ReadLine();
    }
}