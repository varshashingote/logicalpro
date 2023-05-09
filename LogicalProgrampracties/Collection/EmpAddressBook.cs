using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogicalProgrampracties.Collection
{
    public class EmpAddressBook
    {
        public void add()
        {
            Dictionary<string, EmpBook> dic2 = new Dictionary<string, EmpBook>();
            EmpBook emp = new EmpBook(1, "varsha", 30000);
            dic2.Add("Emp1", emp);
            EmpBook emp1 = new EmpBook(2, "vasu", 4000);
            dic2.Add("Emp2", emp1);
            EmpBook emp2 = new EmpBook(3, "Shiv", 5000);
            dic2.Add("Emp3", emp2);
           foreach(KeyValuePair<string,EmpBook>ee in dic2)
            {
                EmpBook obj = ee.Value;
                Console.WriteLine(obj.EmpId+" "+obj.Name+" "+obj.salary);
            }

        }



    }
}
