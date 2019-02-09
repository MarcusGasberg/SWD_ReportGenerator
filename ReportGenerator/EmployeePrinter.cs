using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    /// <summary>
    /// Formats the Employee by Name first, Salary last
    /// </summary>
    public class EmployeeByNameFormatter : IFormatter<IEmployee>
    {
        public string FormatToString(IEmployee item)
        {
            return string.Format($"{item.Name} {item.Salary}");
        }
    }

    /// <summary>
    /// Formats the Employee by Salary first, Name last
    /// </summary>
    public class EmployeeBySalaryFormatter : IFormatter<IEmployee>
    {
        public string FormatToString(IEmployee item)
        {
            return string.Format($"{item.Salary} {item.Name}");
        }
    }

    /// <summary>
    /// Formats the Employee to be printed by age if the employee has an age
    /// Yes it would be easier to just the change the Employee domain, but that wasn't the point
    /// </summary>
    public class EmployeeByAgeFormatter : IFormatter<IEmployee>
    {
        public string FormatToString(IEmployee item)
        {
            return string.Format($"{(item as EmployeeWithAge)?.Age} {item.Name} {item.Salary}");
        }
    }

    /// <summary>
    /// Prints something to the console in a specific format
    /// </summary>
    /// <typeparam name="T">The type to be printed. A respectable <see cref="IFormatter{T}"/> must be created</typeparam>
    public class Printer<T> : IPrinter<T>
    {
        public Printer(IFormatter<T> formatter)
        {
            Formatter = formatter;
        }

        public IFormatter<T> Formatter { get; set; }

        public void Print(IEnumerable<T> toPrint)
        {
            foreach (var item in toPrint)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(Formatter.FormatToString(item));
                Console.WriteLine("------------------");
            }
        }
    }
}
