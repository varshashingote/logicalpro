using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string mobno{ get; set; }
        public Student(int id, string nm,string mobno)
        {
            this.Id = id;
            this.Name = nm;
            this.mobno = mobno;

        }
       

    }
}
