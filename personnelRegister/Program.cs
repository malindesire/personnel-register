namespace personnelRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Ange namn:");
            string name = Console.ReadLine();
            Console.WriteLine("Ange lön:");
            int salary = int.Parse(Console.ReadLine());

            employees.Add(new Employee(name, salary));

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Full name: " + employee.fullName);
                Console.WriteLine("Monthly salary: " + employee.monthlySalary);
            }
        }
    }

    public class Employee
    {
        public string fullName;
        public int monthlySalary;

        public Employee(string name, int salary)
        {
            fullName = name;
            monthlySalary = salary;
        }
    }
}

