using Microsoft.Extensions.Configuration;
using Sprout.Exam.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Business
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly IConfiguration _configuration;
        public DatabaseManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }
    }
}
