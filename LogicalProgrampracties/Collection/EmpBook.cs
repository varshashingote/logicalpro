using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class EmpBook
    {
        public int EmpId { get; set; } 
        public string Name { get; set; }
        public int salary { get; set; }
        public EmpBook(int EmpId,string Name,int salary)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.salary = salary;
        }

    }
}
