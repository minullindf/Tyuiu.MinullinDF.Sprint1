using Tyuiu.MinullinDF.Sprint1.Task4.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string zv = new string('*', 75);

        Console.Title = "Спринт #1 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой. arctg(x)/e^y                 *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);

        double x;
        Console.WriteLine("Введите X: ");
        x = Convert.ToDouble(Console.ReadLine());

        double y;
        Console.WriteLine("Введите Y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}