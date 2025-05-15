using _04_18_25.Person;

namespace _04_18_25
{
    public class Program
    {
        static void Main(string[] args)
        {
            Departament dep = new Departament();

            Employee emp1 = new Employee("nihat","memmedov",20,1000);      
            Employee emp2 = new Employee("Anar2", "Abbasov", 22, 1500);
            Employee emp3 = new Employee("Anar1", "Abbasov", 22, 1500);
            Employee emp4 = new Employee("Anar3", "Abbasov", 23, 1400);
            dep.AddEmployee(emp1);
            dep.AddEmployee(emp2);
            dep.AddEmployee(emp3);
            dep.AddEmployee(emp4);

            dep.GetAllEmployees();
            //dep.GetEmployeeById(1);
            //dep.GetAllEmployeesBySalary(1500);
            
        }
    }
}
