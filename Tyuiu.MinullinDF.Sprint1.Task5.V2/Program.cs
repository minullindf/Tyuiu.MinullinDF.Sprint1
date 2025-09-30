using Tyuiu.MinullinDF.Sprint1.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string zv = new string('*', 75);

        Console.Title = "Спринт #1 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
        Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому         *");
        Console.WriteLine("* с помощью класса Convert.                                               *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);

        double far;
        Console.WriteLine("Введите градусы по Фаренгейту: ");
        far = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        Console.WriteLine(ds.FahrenheitToСelsius(far));

        Console.ReadLine();
    }
}