﻿using CRUDADO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CRUDADO.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            List<Teacher> teacherList = new List<Teacher>();
            string connectionString = Configuration["ConnectionStrings:TrainingDbContext"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "Select * From Teacher";
                SqlCommand command = new SqlCommand(sql, connection); 
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        Teacher teacher= new Teacher();
                        teacher.Id = Convert.ToInt32(dataReader["ID"]);
                        teacher.Name = Convert.ToString(dataReader["Name"]);
                        teacher.Skills = Convert.ToString(dataReader["Skills"]);
                        teacher.TotalStudents = Convert.ToInt32(dataReader["TotalStudents"]);
                        teacher.Salary = Convert.ToDecimal(dataReader["Salary"]);
                        teacher.AddedOn = Convert.ToDateTime(dataReader["AddedOn"]);
                        teacherList.Add(teacher);
                    }
                }
                connection.Close();
            }
            return View(teacherList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:TrainingDbContext"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = $"Insert into Teacher(Name, Skills,TotalStudents,Salary) Values('{teacher.Name}','{teacher.Skills}','{teacher.TotalStudents}','{teacher.Salary}')";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return RedirectToAction("Index");
                }
            }
            else
                return View();
        }
        public IActionResult Update(int id)
        {
            string connectionString = Configuration["ConnectionStrings:TrainingDbContext"];
            Teacher teacher = new Teacher();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Select * From Teacher Where Id='{id}'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        teacher.Id = Convert.ToInt32(dataReader["Id"]);
                        teacher.Name = Convert.ToString(dataReader["Name"]);
                        teacher.Skills = Convert.ToString(dataReader["Skills"]);
                        teacher.TotalStudents = Convert.ToInt32(dataReader["TotalStudents"]);
                        teacher.Salary = Convert.ToDecimal(dataReader["Salary"]);
                        teacher.AddedOn = Convert.ToDateTime(dataReader["AddedOn"]);
                    }
                }
                connection.Close();
            }
            return View(teacher);
        }
        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update(Teacher teacher)
        {
            string connectionString = Configuration["ConnectionStrings:TrainingDbContext"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Update Teacher SET Name='{teacher.Name}', Skills='{teacher.Skills}', TotalStudents='{teacher.TotalStudents}', Salary='{teacher.Salary}' Where Id='{teacher.Id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            string connectionString = Configuration["ConnectionStrings:TrainingDbContext"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Delete From Teacher Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        ViewBag.Result = "Operation got error:" + ex.Message;
                    }
                    connection.Close();
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }



       /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}