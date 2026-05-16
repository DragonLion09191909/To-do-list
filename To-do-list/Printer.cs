using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    internal class Printer
    {
        public static void PrintByCase(ConsoleKeyInfo input, Operator op)
        {
            switch (input.Key)
            {
                case ConsoleKey.P:
                    Console.Clear();
                    Console.WriteLine("Print your doing there!");
                    op.AddInList(Console.ReadLine());
                    PrintList(op);
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    Console.WriteLine("Choose index you want to delete");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        op.DeleteInList(index);
                        PrintList(op);
                    }
                    else throw new Exception("This index doesn't exist!");


                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Unknow method!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
        private static void PrintList(Operator op)
        {
            Console.Clear();
            Console.WriteLine("Your current plans:");

            foreach (var item in op.list)
            {
                int IndexOfDoing = op.list.IndexOf(item) + 1;

                switch (item.State)
                {
                    case To_Do_List.Status.Active:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case To_Do_List.Status.Cancelled:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case To_Do_List.Status.Done:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                Console.WriteLine($"- {IndexOfDoing}:{item.Doing}");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        public  static void PrintChoices()
        {
            Console.WriteLine("You can complete operations:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t[C]-Change status of doing: green-Done, yellow-Active,red-Cancelled");
            Console.WriteLine("\t[D]-Delete doing");
            Console.WriteLine("\t[P]-Print doings");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintError(Exception ex)
        {
            Console.Clear();
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ForegroundColor = oldColor;
            Console.ReadLine();
            Console.Clear();
        }
    }
}
