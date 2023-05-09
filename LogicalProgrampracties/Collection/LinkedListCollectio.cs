using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class LinkedListCollectio
    {
        public void ListExample()
        { 
          List<String> li = new List<String>();
            li.Add("Vasu");
            li.Add("shiv");
            li.Add("shingote");
            li.Add("suraj");
            li.Add("varsha");
            li.Remove("shiv");
            li.Insert(2,"shivadnya");
          
            foreach(String str in li)
            {
                Console.WriteLine(str);
            }
          

     
       
       


            

        }
    }
}
