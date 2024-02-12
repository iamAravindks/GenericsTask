

namespace StackGenerics
{
    public class Menu<T> where T:struct
    {
        private TStack<T> _stack = null!;
        public Menu()
        {
            _stack = new TStack<T>();
        }

        public void HandlePush()
        {
            Console.WriteLine("Enter the item you want to push : ");
            string? userInput = Console.ReadLine();
            try
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    _stack.Push(default(T));
                    Console.WriteLine("You entered nothing ,so pushing the default value");
                }
                else
                {
                    T item = (T)Convert.ChangeType(userInput, typeof(T));
                    _stack.Push(item);
                    Console.WriteLine($"Item '{item}' pushed successfully.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input format. Please enter a valid {typeof(T).Name} value.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid input. Failed to push item to the stack.");
            }
        }

        public void HandlePop()
        {
            try
            {
                T popedItem = _stack.Pop();
                Console.WriteLine($"Item {popedItem} popped out successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void HandlePeek()
        {
            if (_stack.IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.Write($"Peeked the stack : {_stack.Peek()}");
            }
        }

        public void HandleDisplay()
        {
            _stack.Display();
        }

        public static void RunMenu(Menu<T> menu)
        {
            while (true)
            {
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Back to main menu");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            menu.HandlePush();
                            break;
                        case 2:
                            menu.HandlePop();
                            break;
                        case 3:
                            menu.HandlePeek();
                            break;
                        case 4:
                            menu.HandleDisplay();
                            break;
                        case 5:
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
            }
        }

    }


    

}

