using System;
using System.Collections.Generic;
using System.Text;
using static To_do_list.TodoList;

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
                    PrintList(op.List);
                    
                    break;
                case ConsoleKey.C:
                    Console.Clear();
                    Console.WriteLine("Choose index you want to change status:");
                    if (int.TryParse(Console.ReadLine(), out int inputOfIndex))
                    {
                        Console.WriteLine("Choose status for this doing (Active, Done, Cancelled):");
                        op.ChangeStatus(inputOfIndex, Console.ReadLine());
                        PrintList(op.List);
                        
                    }
                    else throw new Exception("This index doesn't exist!");
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    Console.WriteLine("Choose index you want to delete:");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        op.DeleteInList(index);
                        PrintList(op.List);
                        
                    }
                    else throw new Exception("This index doesn't exist!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Unknown method!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }

        public static void PrintList(List<TodoList> list)
        {
            Console.Clear();
            Console.WriteLine("Your current plans:");
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    int indexOfDoing = list.IndexOf(item) + 1;

                    switch (item.State)
                    {
                        case TodoList.Status.Active:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case TodoList.Status.Cancelled:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case TodoList.Status.Done:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }

                    Console.WriteLine($"- {indexOfDoing}:{item.Title}");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Empty");
                Console.ResetColor();
            }
        }

        public static void PrintChoices()
        {
            Console.WriteLine("You can complete operations:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t[C]-Change status of doing: green-Done, yellow-Active, red-Cancelled");
            Console.WriteLine("\t[D]-Delete doing");
            Console.WriteLine("\t[P]-Print doings");
            Console.ResetColor();
        }

        public static void PrintError(Exception ex)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }

}
