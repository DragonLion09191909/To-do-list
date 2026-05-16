using System;
using System.Collections.Generic;
using System.Text;

namespace To_do_list
{
    internal class Operator
    {
        public List<To_Do_List> list=new List<To_Do_List>();
        public string AddInList(string text)
        {
            bool isVerified = Validator.Check(text);
            if (isVerified)
            {
                list.Add(new To_Do_List(text));
                return text;
            }
            else throw new Exception("Your doing is empty or too big(max 100)!");



        }
        public void DeleteInList(int index)
        {
            int input = index - 1;
            if(input < list.Count && input >= 0) list.RemoveAt(input);

        }
        public void ChangeStatus(int index, string  status)
        {
            int input=index - 1;
            if((input>=0 && input<list.Count) && !string.IsNullOrEmpty(status))
            {
               
               
            }

        }
             


    }
        
    
}
