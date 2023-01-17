using AspNetCoreApiWebApplication.Models;
using AspNetCoreApiWebApplication.ViewModles;

namespace AspNetCoreApiWebApplication.Services
{
    public interface IEmployeeService
    {
        // <summary>
        // list of all employees
        // </summary>
        // <returns></returns>
        public List<Employees> GetEmployeesList();

        /// <summary>
        /// get employee details by employee id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public Employees GetEmployeeDetailsById(int empId);

        /// <summary>
        ///  add edit employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        public ResponseModel SaveEmployee(Employees employee);

        /// <summary>
        /// delete employees
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public ResponseModel DeleteEmployee(int employeeId);



    }
}
