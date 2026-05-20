using System.Threading.Channels;

namespace To_do_list
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var op = new Operator();
            op.OnListChanged += () => JsonSaver.Save(op.List);
            op.List = JsonSaver.Load();
            Console.WriteLine("Hello, friend! What plans do you have for today?");
            while (true)
            {
                try
                {
                    Printer.PrintList(JsonSaver.Load());
                    Printer.PrintChoices();
                    var input = Console.ReadKey();
                    Printer.PrintByCase(input, op);

                }
                catch(Exception ex)
                {
                   Printer.PrintError(ex);

                }
            }
            
        }
        
        
        
    }
    
}
