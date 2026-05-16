using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace To_do_list
{
    internal class To_Do_List
    {
     
       
       public Status State { get ;   set; }
       
       public string Doing { get ;  private set; }
       public enum Status { Done, Cancelled, Active }

       public To_Do_List(string doing)
        {
            Doing = doing;
            State = Status.Active;
            
        }
    }
}
