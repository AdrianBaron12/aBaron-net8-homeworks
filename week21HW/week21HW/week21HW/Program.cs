//Exercise 2

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] vector = new int[4, 3]
     {{123,345,567},{12,56,-12 },{34,-98,65},{765,543,321}};

        Console.WriteLine($"The two elements are: {vector[1, 1]} , {vector[2, 1]}");

        //Exercise 3

        List<string> names = new List<string>();
        names.Add("Lacramioara");
        names.Add("Maria");
        names.Add("Andrei");
        if (!names.Contains("Ana"))
        {
            names.Add("Ana");
            Console.WriteLine(names.Last());
        }
        else
        {
            Console.WriteLine("List has the name Ana in");
        }

        //Exercise 4

        Stack<int> intStack = new Stack<int>();
        intStack.Push(14);
        intStack.Push(16);

        if (intStack.Contains(30) || intStack.Sum() == 30)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        //Exercise 5

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(8);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Enqueue(7);

        if(!(queue.Peek()>0 &&  (queue.Peek() %3==0 || queue.Peek() % 7 == 0)))
        {
            queue.Dequeue();
            
        }
        Console.WriteLine($"The new peek is {queue.Peek()}");
    }
}