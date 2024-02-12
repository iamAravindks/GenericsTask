using ChatQueue;

Menu menu = new Menu();
while (true)
{
    int choice;
    Console.WriteLine("Chat Queue Operations:");
    Console.WriteLine("1. Enqueue message");
    Console.WriteLine("2. Dequeue message");
    Console.WriteLine("3. Check Queue status");
    Console.WriteLine("4. Exit ");
    
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            menu.HandleEnqueueMessage();
            break;
        case 2:
            menu.HandleDequeueMessage();
            break;
        case 3:
            menu.HandleQueueStatus();
            break;
        case 4:
            Console.WriteLine("Exiting menu");
            break;
    }
    if (choice == 4)
    {
        break;
    }
}