using Tyuiu.MinullinDF.Sprint1.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string zv = new string('*', 75);

        Console.Title = "Спринт #0 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 48/12-48/6/4            *");
        Console.WriteLine("* И печатает результат на экране.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);
        Console.WriteLine("* 48/12-48/6/4                                                            *");
        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        Console.WriteLine(ds.Calculate());

        Console.ReadLine();
    }
}