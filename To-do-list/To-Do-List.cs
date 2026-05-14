using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace To_do_list
{
    internal class To_Do_List
    {
     
       private string _doing;
       private Status _status;
       public Status State { get { return _status; }  }
       
       public string Doing { get { return _doing; } }
       public enum Status { Done, Cancelled, Active }

       public To_Do_List(string doing)
        {
            _doing = doing;
            _status= Status.Active;
            
        }
    }
}
