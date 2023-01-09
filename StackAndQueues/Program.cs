namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Stack And Queues Problems\n");
            Console.WriteLine("Please Select Option From List");
            Console.WriteLine("\n1. Create a Stack \n2. To Peek And Pop the Element from stack");
            int option = int.Parse(Console.ReadLine());
            //Calling Class 
            LinkedListStack linkedListStack = new LinkedListStack();
            switch (option)
            {
                case 1:
                    linkedListStack.Push(70);    //Adding data to stack
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                   
                    //Display Message
                    Console.WriteLine("\n");
                    linkedListStack.Display();
                    break;
                case 2:
                    linkedListStack.Push(70);    //UC 2
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    Console.WriteLine("----------------------------");
                    //Peek Value from Stack
                    linkedListStack.Peek();
                    Console.WriteLine("----------------------------");
                    linkedListStack.Pop();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            
           

            
            Console.ReadLine();
        }
    }
}