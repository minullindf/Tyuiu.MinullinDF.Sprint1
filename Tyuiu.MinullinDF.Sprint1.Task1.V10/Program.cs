using Tyuiu.MinullinDF.Sprint1.Task1.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string zv = new string('*', 75);

        Console.Title = "Спринт #1 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x+y)/(1+x) и печатает его на экране.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);

        double x, y;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}