namespace ReportGenerator
{
    public class Employee : IEmployee
    {
        public Employee() : this("", 0)
        {
        }

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public uint Salary { get; private set; }
        
    }

    public class EmployeeWithAge : Employee
    {
        public EmployeeWithAge() : this("",0,0)
        {
            
        }

        public EmployeeWithAge(string name, uint salary, uint age) :base(name,salary)
        {
            Age = age;
        }
        public uint Age { get; private set; }
    }
}