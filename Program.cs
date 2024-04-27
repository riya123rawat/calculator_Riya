// See https://aka.ms/new-console-template for more informatio
Console.ForegroundColor = ConsoleColor.Green;

int num1 = 0;
int num2 = 0;
int result = 0;
bool running = true;

while (running == true)
{

    Console.WriteLine("Calulator program");
    Console.WriteLine("...................");

    Console.Write("Enter number 1: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("/n Menu:");
    Console.WriteLine("1 : Add");
    Console.WriteLine("2 : Subtract");
    Console.WriteLine("3 : Multiplication");
    Console.WriteLine("4 : Division");
    Console.WriteLine("9 : Exit");


    switch (Console.ReadLine())
    {
        case "1":
            result = num1 + num2;
            Console.WriteLine($"your result:{num1}+{num2}=" + result);
            break;

        case "2":
            result = num1 - num2;
            Console.WriteLine($"your result:{num1}-{num2}=" + result);
            break;

        case "3":
            result = num1 * num2;
            Console.WriteLine($"your result:{num1}*{num2}=" + result);
            break;

        case "4":
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"your result:{num1}/{num2}=" + result);
            }
            else
            {
                Console.WriteLine("Error:Division by zero is not allowed");
            }
            break;


        case "9":
            while (running == false)
                Console.WriteLine("Exit");
            break;

        default:
            Console.WriteLine("That was not a valid option");
            break;
    }

    Console.ReadKey();
}
