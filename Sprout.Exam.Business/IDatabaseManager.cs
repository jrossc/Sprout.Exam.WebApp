using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Business
{
    public interface IDatabaseManager
    {
        string GetConnectionString(string connectionName);
    }
}
