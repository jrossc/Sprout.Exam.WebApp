using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sprout.Exam.Business.DataTransferObjects;

namespace Sprout.Exam.WebApp
{
    public static class StaticEmployees
    {
        //public static List<EmployeeDto> ResultList = new()
        //{
        //    new EmployeeDto
        //    {
        //        Birthdate = "1993-03-25",
        //        FullName = "Jane Doe",
        //        Id = 1,
        //        Tin = "123215413",
        //        TypeId = 1
        //    },
        //    new EmployeeDto
        //    {
        //        Birthdate = "1993-05-28",
        //        FullName = "John Doe",
        //        Id = 2,
        //        Tin = "957125412",
        //        TypeId = 2
        //    }
        //};

        //public static List<Employee> ResultList()
        //{   
        //    List<Employee> empList = new List<Employee>();
        //    string conn_string = @"Server=JOHNRAYDESKTOP\\SQLEXPRESS;Database=SproutExamDb;Integrated Security=True;";

        //    using (SqlConnection connection = new SqlConnection(conn_string))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM Employees";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Employee emp = new Employee();
        //                    emp.Id = Convert.ToInt32(reader[0].ToString());
        //                    emp.FullName = reader[1].ToString();
        //                    emp.Birthdate = reader[2].ToString();
        //                    emp.Tin = reader[3].ToString();
        //                    emp.EmployeeTypeId = Convert.ToInt32(reader[4].ToString());
        //                    empList.Add(emp);
        //                }
        //            }
        //        }
        //    }

        //    return empList;
        //}
    }
}
