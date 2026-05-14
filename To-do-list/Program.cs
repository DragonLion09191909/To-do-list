namespace To_do_list
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var op = new Operator();
            Console.WriteLine("Hello, friend! What plans do you have for today?");
            while (true)
            {
                try
                {
                    op.AddInList(Console.ReadLine());
                    PrintList(op);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
        static void PrintList(Operator op)
        {
            
            foreach (var item in op.list)
            {
                switch (item.State)
                {
                    case To_Do_List.Status.Active: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    case To_Do_List.Status.Cancelled: Console.ForegroundColor = ConsoleColor.Red; break;
                    case To_Do_List.Status.Done: Console.ForegroundColor = ConsoleColor.Green; break;
                }
                Console.WriteLine(item.Doing);
            }
        }
    }
}
