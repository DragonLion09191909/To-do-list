using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    internal class Operator
    {
        public event Action OnListChanged;
        public List<TodoList> _list=new List<TodoList>();
        public List<TodoList> List
        {
            get => _list;
            set
            {
                _list = value;
                OnListChanged?.Invoke(); // Триггер при полной замене списка (например, при загрузке)
            }
        }

        public string AddInList(string text)
        {
            bool isVerified = Validator.IsValid(text);
            if (isVerified)
            {
                List.Add(new TodoList(text));
                OnListChanged?.Invoke();
                return text;
            }
            else throw new Exception("Your doing is empty or too big(max 100)!");



        }
        public void DeleteInList(int index)
        {
            int input = index - 1;
            if (input < _list.Count && input >= 0)
            {
                _list.RemoveAt(input);
                OnListChanged?.Invoke(); 
            }
            else throw new Exception("Index out of range!");

        }
        public void ChangeStatus(int index, string  status)
        {
            int input=index - 1;
            if ((input >= 0 && input < List.Count) && !string.IsNullOrEmpty(status))
            {
                if (status.StartsWith("A", StringComparison.OrdinalIgnoreCase)) List[input].State = TodoList.Status.Active;
                else if (status.StartsWith("D", StringComparison.OrdinalIgnoreCase)) List[input].State = TodoList.Status.Done;
                else if (status.StartsWith("C", StringComparison.OrdinalIgnoreCase)) List[input].State = TodoList.Status.Cancelled;
                else throw new Exception("Unknown status");

                OnListChanged?.Invoke();


            }
            else throw new Exception("Your input is empty");

        }
             


    }
        
    
}
