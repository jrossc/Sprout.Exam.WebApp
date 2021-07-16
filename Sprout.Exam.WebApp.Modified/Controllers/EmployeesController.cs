using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprout.Exam.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Modified.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeDAL _dto;

        public EmployeesController(IEmployeeDAL dto)
        {
            _dto = dto;
        }

        /// <summary>
        /// Refactor this method to go through proper layers and fetch from the DB.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           // var result = await Task.FromResult(StaticEmployees.ResultList());

            var result = await Task.FromResult(_dto.Get());
            return Ok(result);
        }
    }
}
