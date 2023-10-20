using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripConsole
{
    internal class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person Owner { get; set; }
        public List<Debtors> Debtors { get; set; }
    }
}
