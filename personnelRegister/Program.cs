namespace personnelRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            showMenu();
            string selectedAction = Console.ReadLine();

            while (selectedAction != "99")
            {
                switch (selectedAction)
                {
                    case "1":
                        addEmployee(employees);
                        break;
                    case "2":
                        showRegister(employees);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                showMenu();
                selectedAction = Console.ReadLine();
            }
        }

        private static void showMenu()
        {
            Console.WriteLine("Choose the action you want to do:");
            Console.WriteLine("1. Add new employee");
            Console.WriteLine("2. Show employee register");
            Console.WriteLine("99. Exit");
        }

        private static List<Employee> addEmployee(List<Employee> employees)
        {
            Console.WriteLine("Ange namn:");
            string name = Console.ReadLine();
            Console.WriteLine("Ange lön:");
            int salary = int.Parse(Console.ReadLine());

            employees.Add(new Employee(name, salary));

            return employees;
        }
        private static void showRegister(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Full name: " + employee.fullName + ", Monthly salary: " + employee.monthlySalary);
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

