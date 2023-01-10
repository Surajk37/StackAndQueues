namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Stack And Queues Problems\n");
            Console.WriteLine("Please Select Option From List");
            Console.WriteLine("\n1. Create a Stack \n2. To Peek And Pop the Element from stack \n3. Create a Queue");
            int option = int.Parse(Console.ReadLine());
            //Calling Class and addind data to stack
            LinkedListStack linkedListStack = new LinkedListStack();
            
            //Calling Class and Adding Data in Queue
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            switch (option)
            {
                case 1:
                    linkedListStack.Push(70);    //UC1 -Adding data to stack
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                   
                    //Display Message
                    Console.WriteLine("\n");
                    linkedListStack.Display();
                    break;
                case 2:
                    linkedListStack.Push(70);    //UC-2
                    linkedListStack.Push(30);
                    linkedListStack.Push(56);
                    Console.WriteLine("----------------------------");
                    //Peek Value from Stack
                    linkedListStack.Peek();
                    Console.WriteLine("----------------------------");
                    linkedListStack.Pop();
                    break;
                case 3:
                    linkedListQueue.Enqueue(56);     //UC-3
                    linkedListQueue.Enqueue(30);
                    linkedListQueue.Enqueue(70);
                    Console.WriteLine("----------------------------");
                    //Display Queue
                    linkedListQueue.Display();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }         
            Console.ReadLine();
        }
    }
}