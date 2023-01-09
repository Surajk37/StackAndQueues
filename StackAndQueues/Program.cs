namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Stack And Queues Problems\n");
            //Calling Class and Adding Data in Stack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);

            //Display Message
            Console.WriteLine("\n");
            linkedListStack.Display();
            Console.ReadLine();
        }
    }
}