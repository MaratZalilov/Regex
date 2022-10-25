using System.Text.RegularExpressions;
void tel()
{
    Console.WriteLine("Введите номер телефона");
    string enter = Console.ReadLine();

    Regex regex = new Regex(@"\d{11}$");
    Regex regex2 = new Regex(@"\d{1}\d{3}\d{3}\d{2}\d{2}$");
    Regex regex4 = new Regex(@"\d{1} \d{3} \d{3} \d{2} \d{2}$");
    Regex regex3 = new Regex(@"\d{1}-\d{3}-\d{3}-\d{2}-\d{2}$");
    regex.IsMatch(enter);
    if (regex.IsMatch(enter))
    {
        Console.WriteLine("Верно");
    }
    else if (regex2.IsMatch(enter))
    {
        Console.WriteLine("Верно");
    }
    else if (regex3.IsMatch(enter))
    {
        Console.WriteLine("Верно");
    }
    else if (regex4.IsMatch(enter))
    {
        Console.WriteLine("Верно");
    }
    else
    {
        Console.WriteLine("Номер не сооответсвует шаблону");
    }
}
//tel();
bool mail()
{
    Console.WriteLine("Введите эелектронную почту");
    string enter = Console.ReadLine();
    Regex mail = new Regex(@"^[a - z]{1,20}@mail.ru\w*");
    mail.IsMatch(enter);
    if (!mail.IsMatch(enter))
    {
        Console.WriteLine("Почта не сооответсвует шаблону");
        return false;
    }
    else
    {
        Console.WriteLine("Верно");
        return true;
    }
}
//mail();

