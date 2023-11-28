Console.WriteLine("Введите первое число");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Выберите оператор + - / *");

string action = Console.ReadLine();

switch (action)
{
    case "+":
        Console.WriteLine(number1 + number2);
        break;

    case "-":
        Console.WriteLine(number1 - number2);
        break;

    case "/":
        Console.WriteLine(number1 * number2);
        break;
    case "*":
        Console.WriteLine(number1 / number2);
        break;

    default:
        Console.WriteLine("");

        break;

}



Console.ReadKey();