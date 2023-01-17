using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee : IEmployee
    {
        private string Name { get; set; }
        public Employee()
        {
            Name = "Tushar";
            
        }
        public string GetName()
        {
            return Name;
            
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetDefaultName()
        {
            return "Tushar";
        }
        public string DisplayName()
        {
            return "abc";
        }
    }
}
