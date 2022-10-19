// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Создать класс "Детский сад", с именем, адресом, специализацией
// Количеством детей и статическим полем максимальное количество детей.
// В описании кода использовать ключевое слово this.
// Описать конструктор с параметрами имя и адрес, создать статический конструктор.
// Сделать метод ввода количества детей с передачей параметров
// в метод и специализацией детского сада.
// Написать метод для вывода информации о недоборе или переполнения
// сада и какой процент.Также сделать функцию вывода информации 
// о детском саде. Создать три детских сада.

using System.Text.RegularExpressions;

garden one = new garden("Василек","Кирова 105","С физическим уклоном",50);
one.Show();
Console.WriteLine();
garden two = new garden();
two.Show();
Console.WriteLine();
garden three = new garden();
three.Show();

Console.Title = "******";
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.SetWindowSize(100, 30);
        Console.WriteLine("Начало программы детские сады и специализация");


class garden              // Создаем класс  детский сад
{
    private string _name; // поле имя детского сада
    private string _adress; // поле адрес детского сада
    private string _description; // поле пояснение к детскому саду (специализация)
    private int _count_child; // количество детей
    public static int _max_count_child; // максимальное кол-во детей

    public garden(string name, string adress, string description,
        int count_child)
    {
        this._name = name;
        this._adress = adress;
        this._description = description;
        this._count_child = count_child;
    }
    public garden() // Описать конструктор с параметрами имя и адрес,
                    // создать статический конструктор.
        {
        _name = "Ромашка";
        _adress = "Пионерский 33";
    }
    static garden() 
    {
        _max_count_child = 25;
    }
    public void Show() // Метод для вывода информации
    {
        Console.WriteLine("Название детского сада : {0}", _name);
        Console.WriteLine("Адрес: {0}", _adress);
        Console.WriteLine("Специализация :{0}", _description);
        Console.WriteLine("Кол - во детей :{0}", _count_child);
    }
}

