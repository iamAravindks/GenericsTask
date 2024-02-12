using StackGenerics;


while (true)
{
    Console.WriteLine("Select Stack Type:");
    Console.WriteLine("1. int Stack");
    Console.WriteLine("2. character Stack");
    Console.WriteLine("3. double Stack");
    Console.WriteLine("4. Exit");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Creating int stack...");
                Menu<int> intMenu = new Menu<int>();
                Menu<int>.RunMenu(intMenu);
                break;
            case 2:
                Console.WriteLine("Creating character stack...");
                Menu<char> charMenu = new Menu<char>();
                Menu<char>.RunMenu(charMenu);
                break;
            case 3:
                Console.WriteLine("Creating double stack...");
                Menu<double> doubleMenu = new Menu<double>();
                Menu<double>.RunMenu(doubleMenu);
                break;
            case 4:
                Console.WriteLine("Exiting program...");
                return;
            default:
                Console.WriteLine("Invalid choice. Please select again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }

    if (choice == 4)
    {
        break;
    }
}