using System;
using System.Collections.Generic;
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public Employee(int id, string name, string position)
    {
        ID = id;
        Name = name;
        Position = position;
    }
}
class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; }
    public Department(string departmentName, List<Employee> employees)
    {
        DepartmentName = departmentName;
        Employees = employees;
    }
    public void DisplayEmployees() 
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"| {"ID",-10} | {"Name",-20} | {"Position",-20} |");
        Console.WriteLine("--------------------------------------------------------------");

        foreach(var emp in Employees)
        {
            Console.WriteLine($"| {emp.ID,-10} | {emp.Name,-20} | {emp.Position,-20} |");
        }

        Console.WriteLine("--------------------------------------------------------------");
    }
}
class Information
{
    static void Main()
    {
        List<Employee> employee = new List<Employee>
        {
            new Employee(22103265, "Maksud Mubin", "Software Developer"),
            new Employee(20030927, "Afsin Binte Faruk", "Business Analyst"),
            new Employee(26020033, "Mahim Musfasa", "System Designer"),
            new Employee(24040998, "Alex Niloy", "UI/UX Designer"),
            new Employee(20070927, "Shihat Ahmed", "Project Manager"),
            new Employee(23080049, "Labib Arefin", "QA & Tester"),
        };
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("--Department Information--");
        Department dep = new Department("Systems Analysis & Design", employee);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Department: {dep.DepartmentName}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        dep.DisplayEmployees();
        Console.ResetColor();
    }
}
