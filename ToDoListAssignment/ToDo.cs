using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListAssignment
{
    public class ToDo
    {
        public ToDo()
        {
            Desc = string.Empty;
        }
        public string Desc { get; set; }
        public bool IsDone { get; set; }
    }
}
