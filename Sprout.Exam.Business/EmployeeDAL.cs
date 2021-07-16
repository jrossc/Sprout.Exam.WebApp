using Microsoft.EntityFrameworkCore;
using Sprout.Exam.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Sprout.Exam.Business
{
   public class EmployeeDAL : IEmployeeDAL
    {
        IDatabaseManager _dbm;
        public EmployeeDAL(IDatabaseManager dbm)
        {
            _dbm = dbm;
        }
        public List<Employee> Get()
        {
            List<Employee> empList = new List<Employee>();

            #region I tried to use an ORM framework to do data manipulation
            try
            {
                using (var db = new EmployeeContext(_dbm))
                {
                    var blogs = db.Employee
                        .Where(b => b.isDeleted == false)
                        .OrderBy(b => b.Id)
                        .ToList();

                    empList = blogs;
                }
            }
            catch (Exception ex)
            {
                string e = ex.Message;
            }
            #endregion

            return empList;
        }

        public Task<bool> Put(EditEmployeeDto dto)
        {

            using (var context = new EmployeeContext(_dbm))
            {
                var emp = context.Employee.FirstOrDefault(m => m.Id == dto.Id);
                emp.FullName = dto.FullName;
                emp.Birthdate = dto.Birthdate.ToString();
                emp.TypeId = dto.TypeId;
                emp.Tin = dto.Tin;
                context.SaveChanges();
            }

            return Task.FromResult(true);

        }

        public Task<bool> Post(CreateEmployeeDto dto)
        {

            using (var context = new EmployeeContext(_dbm))
            {
                var emp = new Employee {
                    FullName = dto.FullName,
                    Birthdate = dto.Birthdate.ToString(),
                    TypeId = dto.TypeId,
                    Tin = dto.Tin,
                    isDeleted = false           
                    };
                context.Employee.Add(emp);
                context.SaveChanges();
            }

            return Task.FromResult(true); ;
        }

        public Task<bool> Delete(int id)
        {

            try
            {
                using (var context = new EmployeeContext(_dbm))
                {
                    var emp = context.Employee.FirstOrDefault(m => m.Id == id);
                    emp.isDeleted = true;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string e = ex.StackTrace + "\n " + ex.Message;
            }

            return Task.FromResult(true); ;
        }

        private string GetConnectionString()
        {
            return _dbm.GetConnectionString("EmployeeDBConnection");
        }
    }
}
