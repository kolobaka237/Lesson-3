Console.WriteLine("Enter student assessment: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int average = (a + b + c + d + e) / 5;
if (average >= 4)
{
    Console.WriteLine("Student admitted");
}
else if (average < 4)
{
    Console.WriteLine("Stedent not admitted");
}

Console.WriteLine();

Console.Write("Enter the number: ");
float number = Convert.ToInt32(Console.ReadLine());
float remainder = number % 2;
if (a == 0)
{
    Console.WriteLine($"Your nuber is Even and I'll multiply it by 3\n{number * 3}");
}
else
{
    Console.WriteLine($"Your nuber is not even and I'll divide it by 2\n{number / 2}");
}

Console.WriteLine();

Console.Write("Hi, it's calculator. Enter first number: ");
double first = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter action: ");
char action = Convert.ToChar(Console.ReadLine());
Console.Write("Enter second number: ");
double second = Convert.ToDouble(Console.ReadLine());
switch (action)  //После получения 2 чисел и знака операции над ними я использую цикл switch. В этом цикле мы будем обрабатывать переменную action.
{                //Цикл проверяет переменную, которая указана в скобках и ищет совпадения по кейсам ниже. Т.е если в переменной хранится '/', то будет выполнен кейс 4, и так со всеми остальными действиями.
    case '+':
        double result = first + second;
        Console.WriteLine(result);
        break;
    case '-':
        result = first - second;
        Console.WriteLine(result);
        break;
     case '*':  
        result = first * second;
        Console.WriteLine(result);
        break;
     case '/':
        result = first / second;
        Console.WriteLine(result);
        break;

}