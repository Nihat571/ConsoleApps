using _04_18_25.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_18_25.Person;

public class Departament
{
    public static int DepartamentNo;
  
    List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        ++DepartamentNo;
        employees.Add(employee);
    }

    public void GetEmployeeById(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.Id == id)
            {
                Console.WriteLine("Tapilan ishcinin datalari:");
                Console.WriteLine($"number:{emp.Id}\nDepartamentNo:{DepartamentNo}\nname:{emp.Name}\nsurname:{emp.Surname}\nAge:{emp.Age}\nsalary:{emp.Salary}");
            }
            
                //throw new MyException($"{id} nomresinde ishci tapilmadi");
            
        }
        
    }

    public void GetAllEmployees()
    {
        foreach (Employee emp in employees) 
        {
            Console.WriteLine($"number:{emp.Id}\n\nDepartamentNo:{DepartamentNo}\nname:{emp.Name}\nsurname:{emp.Surname}\nAge:{emp.Age}\nsalary:{emp.Salary}");
            Console.WriteLine("------------------------------");
        }
    
    }

    public void GetAllEmployeesBySalary(double salary)
    {
        foreach (Employee emp in employees) 
        {
        if(emp.Salary == salary)
            {
                Console.WriteLine("Tapilan ishcinin datalari:");
                Console.WriteLine($"number:{emp.Id}\n\nDepartamentNo:{DepartamentNo}name:{emp.Name}\nsurname:{emp.Surname}\nAge:{emp.Age}\nsalary:{emp.Salary}");
            }
            
        }
    }
}
