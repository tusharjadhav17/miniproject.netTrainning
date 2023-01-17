using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Models.DLA
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int emp_id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        
        void Save();
       // object GetEmployeeById(int id);
    }
}
