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
        private string _count_child; // количество детей
        public static string _max_count_child; // максимальное кол-во детей
    
    public garden( string name, string adress, string description, string count_child, string max_count_child )
{ 
        this._name = name;
        this._adress = adress;
        this._description = description;
        this._count_child = count_child; 
    }
}

