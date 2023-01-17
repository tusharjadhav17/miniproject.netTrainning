using AspNetCoreApiWebApplication.Models;
using AspNetCoreApiWebApplication.ViewModles;
using Microsoft.Identity.Client;

namespace AspNetCoreApiWebApplication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;
        public EmployeeService(EmpContext context)
        {
            _context = context;
        }
        public List<Employees> GetEmployeesList()
        {
            List<Employees> empList;
            try
            {
                empList = _context.Set<Employees>().ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
            return empList;
        }
        public Employees GetEmployeeDetailsById(int empId)
        {
            Employees emp;
            try
            {
                emp = _context.Find<Employees>(empId);
            }
            catch(Exception ex)
            {
                throw;
            }
            return emp;
        }
        public ResponseModel DeleteEmployee(int employeeId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employees _temp = GetEmployeeDetailsById(employeeId);
                if(_temp != null)
                {
                    _context.Remove<Employees>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Message = "Employee Deleted SuccessFully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Employee Not Found";
                }
            }
            catch(Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error :"+ ex.Message;
            }
            return model;
            //throw new NotImplementedException();
        }

        public ResponseModel SaveEmployee(Employees employeeModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Employees _temp = GetEmployeeDetailsById(employeeModel.EmployeeId);
                if(_temp != null)
                {
                    _temp.Designation = employeeModel.Designation;
                    _temp.EmployeeFirstName = employeeModel.EmployeeFirstName;
                    _temp.EmployeeLastName = employeeModel.EmployeeLastName;
                    _temp.Salary = employeeModel.Salary;
                    _context.Update<Employees>(_temp);
                    model.Message = "Employee Update SuccessFully";
                }
                else
                {
                    _context.Add<Employees>(employeeModel);
                    model.Message = "Employee Inserted SuccessFully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch(Exception ex)
            {
                model.IsSuccess= false;
                model.Message ="Error"+ ex.Message;
            }
            return model;
           // throw new NotImplementedException();
        }
    }
}
