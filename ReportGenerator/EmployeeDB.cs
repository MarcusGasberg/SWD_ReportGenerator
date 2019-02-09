using System.Collections.Generic;

namespace ReportGenerator
{
    /// <summary>
    /// A Data base for employees
    /// </summary>
    public class EmployeeDB : IDatabase<IEmployee>
    {
        private readonly List<IEmployee> _employees;
        private int _currentEmployeeIndex;

        public EmployeeDB()
        {
            _employees = new List<IEmployee>();
            Reset();
        }

        /// <summary>
        /// Resets the <see cref="GetNextEmployee"/>
        /// </summary>
        public void Reset()
        {
            _currentEmployeeIndex = 0;
        }

        /// <summary>
        /// Gets the next employee if it exists
        /// </summary>
        /// <returns>The next employee if it exists, else null</returns>
        public IEmployee GetNextEmployee()
        {
            if (_currentEmployeeIndex == _employees.Count)
                return null;
            return _employees[_currentEmployeeIndex++];
        }
        
        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="employee">The employee to be added to the database</param>
        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }
    }
}