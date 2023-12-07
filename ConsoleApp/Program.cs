using ConsoleApp.classes;
using System.ComponentModel;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


// Розширення string
string s = "subscribe";
Console.WriteLine("Початковий рядок: " + s);
Console.WriteLine("Інвертований рядок: " + s.MyReverse());
Console.WriteLine("Кількість символів s: " + s.MyCount('s'));
Console.WriteLine();


// Розширення узагальненого List
List<short> list = new List<short>() { 2, 4, 6, 2, 2, 4, 7 };
Console.Write("Початковий масив: ");
foreach (short item in list)
    Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine("Кількість елементів 2: " + list.MyCount((short)2));
Console.Write("Масив без повторень: ");
foreach (short item in list.MyUnic())
    Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine();


// Узагальнений "Розширений словник"
ExtendedDictionary<string, int, char> extendedDictionary = new ExtendedDictionary<string, int, char>();
extendedDictionary.Add("Стандартизація та документування програмних систем", 82, 'B');
Console.WriteLine("Додавання предмету: Стандартизація та документування програмних систем - 82 - В");
extendedDictionary.Add("Інформаційна безпека та захист ПЗ", 60, 'E');
Console.WriteLine("Додавання предмету: Інформаційна безпека та захист ПЗ - 60 - E");
extendedDictionary.Add("Математичні методи дослідження операцій", 67, 'D');
Console.WriteLine("Додавання предмету: Математичні методи дослідження операцій - 67 - D");


if (extendedDictionary.ContainsKey("Інформаційна безпека та захист ПЗ"))
    Console.WriteLine("Предмет \"Інформаційна безпека та захист ПЗ\" знайдено");
else
    Console.WriteLine("Предмет \"Інформаційна безпека та захист ПЗ\" не знайдено");
extendedDictionary.Remove("Інформаційна безпека та захист ПЗ");
Console.WriteLine("Видалення предмету: Інформаційна безпека та захист ПЗ");
if (extendedDictionary.ContainsKey("Інформаційна безпека та захист ПЗ"))
    Console.WriteLine("Предмет \"Інформаційна безпека та захист ПЗ\" знайдено");
else
    Console.WriteLine("Предмет \"Інформаційна безпека та захист ПЗ\" не знайдено");

if (extendedDictionary.ContainsValues(84, 'B'))
    Console.WriteLine("Предмет з оцінкою 84,В знайдено");
else
    Console.WriteLine("Предмет з оцінкою 84,В не знайдено");
extendedDictionary["Стандартизація та документування програмних систем"] = (84, 'B');
Console.WriteLine("Виставлення нової оцінки: Стандартизація та документування програмних систем - 84 В");
if (extendedDictionary.ContainsValues(84, 'B'))
    Console.WriteLine("Предмет з оцінкою 84,В знайдено");
else
    Console.WriteLine("Предмет з оцінкою 84,В не знайдено");
Console.WriteLine("Загальна кількість предметів: " + extendedDictionary.Count());
Console.WriteLine();
