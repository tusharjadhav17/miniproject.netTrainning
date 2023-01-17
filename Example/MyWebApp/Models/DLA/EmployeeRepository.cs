using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MyWebApp.Models.DLA
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TrainingDBEntities1 context;
        public EmployeeRepository() 
        {
            context = new TrainingDBEntities1();    
        }
        public EmployeeRepository(TrainingDBEntities1 context)
        {
            this.context = context;
        }
        public IEnumerable<Employee>GetAll()
        {
            return context.Employees.ToList();
        }
        public Employee GetById(int emp_id)
        {
            return context.Employees.Find(emp_id);
        }
        public void Insert(Employee employee)
        {
            context.Employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            long EmpId = (long)id;
            Employee employee = context.Employees.Where(c => c.emp_id == EmpId).FirstOrDefault();
            if(employee != null) 
                context.Employees.Remove(employee);

        }
       /* public void Delete(int emp_id)
        {
            var employee = context.Employees.Find(emp_id);
            if (employee != null) context.Employees.Remove(employee);
        }*/

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        internal static Employee GetemployeeByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}