using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new EmployeeWithAge("Christel", 1000,20));

            //Create report generator and printer
            var reportGenerator = new EmployeeReportGenerator(db);
            var printer = new Printer<IEmployee>(new EmployeeByNameFormatter());
            
            var report = reportGenerator.CompileReport();
            printer.Print(report);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a age-first report
            printer.Formatter = new EmployeeByAgeFormatter();
            report = reportGenerator.CompileReport();
            printer.Print(report);

            Console.ReadKey();
        }
    }
}