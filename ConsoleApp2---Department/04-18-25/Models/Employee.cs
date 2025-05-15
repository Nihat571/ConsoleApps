using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_18_25.Person;

public class Employee
{
    private static int _id;
    public int Id { get; set; }
    public string Name;
    public string Surname;
    public int Age;

    public int DepartmentNo;

    private double salary;
    public double Salary {  get; set; }

    public Employee(string name,string surname,int age,double salary)
    {
        Id =++_id;
        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
    }
    public void ShowInfo()
    {                     
        Console.WriteLine($"name:{Name}\nsurname:{Surname}\nage:{Age}\nsalary:{salary}");
    }                     
}
