using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace To_do_list
{
    internal class TodoList
    {


        public Status State { get; set; }
        public string Title { get; set; } 
        public enum Status { Done, Cancelled, Active }

       
        public TodoList() { }

        public TodoList(string title)
        {
            Title = title;
            State = Status.Active;
        }
    }
}
