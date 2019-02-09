using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportGenerator
{
    /// <summary>
    /// Generates Reports of Employeees fro man Employee Database
    /// </summary>
    public class EmployeeReportGenerator
    {
        private readonly EmployeeDB _employeeDb;

        public EmployeeReportGenerator(EmployeeDB employeeDb)
        {
            _employeeDb = employeeDb ?? throw new ArgumentNullException("employeeDb");
        }

        /// <summary>
        /// Compiles a report from the database
        /// </summary>
        /// <returns>The compiled report</returns>
        public List<IEmployee> CompileReport()
        {
            List<IEmployee> employeesReport = new List<IEmployee>();
            IEmployee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employeesReport.Add(employee);
            }

            return employeesReport;
        }
    }
}