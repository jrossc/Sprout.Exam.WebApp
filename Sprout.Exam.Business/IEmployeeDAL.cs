using Sprout.Exam.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business
{
    public interface IEmployeeDAL
    {
        List<Employee> Get();
        Task<bool> Put(EditEmployeeDto dto);

        Task<bool> Post(CreateEmployeeDto dto);

        Task<bool> Delete(int id);
    }
}
