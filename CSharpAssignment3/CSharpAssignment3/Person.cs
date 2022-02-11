using System;

//Designing and Building Classes using object-oriented principles
//1-6)OOP: /Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/
//Interfaces
public interface IPersonService
{
    //Calculate Age of the Person
    public void CalculateAge(DateTime dob);
    //Calculate the Salary of the person, Use decimal for salary, salary cannot be negative number
    public decimal CalculateSalary(int hourWork, decimal payment);
    //Can have multiple Addresses, should have method to get addresses
    public void GetMultiAddresses();
}
public interface IInstructorService : IPersonService
{
    //Belongs to one Department and he can be Head of the Department
    //Instructor will have added bonus salary based on his experience, calculate his years of experience based on Join Date
    public void BonusSalary(DateTime joinDate);
}
public interface IStudentService : IPersonService
{
    //Can take multiple courses

    //Calculate student GPA based on grades for courses
    public decimal CalculateGPA();
    //Each course will have grade from A to F

}


//Abstract
public abstract class Person: IPersonService
{
    //Fields
    protected string name;
    protected int id;
    protected int age;
    protected decimal salary;
    protected string[] addresses;

    //Method
    public virtual void TaskToDo() { }
    public void CalculateAge(DateTime dob)
    {
        age = DateTime.Now.Year - dob.Year;
    }
    public decimal CalculateSalary(int hourWork, decimal payment)
    {
        salary = hourWork * payment;
        return salary;
    }
    public void GetMultiAddresses()
    {
        foreach(string address in addresses)
        {
            Console.WriteLine(address);
        }
    }

    //Properties
    public string Name { get { return name; } set { name = value; } }
    public int Id { get { return id; } set { id = value; } }
    public int Age { get { return age; } }
}

//Concrete classes
public class Instructor: Person, IInstructorService
{
    //Field
    //Belongs to one Department and he can be Head of the Department
    private int departmentId;
    private bool headOfDepartment;

    //Constructor
    public Instructor(int id, int departmentId, bool headOfDepartment = false)
    {
        this.id = id;
        this.departmentId = departmentId;
        this.headOfDepartment = headOfDepartment;
    }

    //Method
    public void BonusSalary(DateTime joinDate)
    {
        salary += (DateTime.Now.Year - joinDate.Year) * 5.0m;
    }
    public override void TaskToDo()
    {
        Console.WriteLine("Grade students");
    }

    //Properties
    public int DepartmentId { get { return departmentId; } set { departmentId = value; } }
}

public class Student : Person, IStudentService
{
    //Fields
    //Course Id and course grade (A-F)
    List<(int, char)> currentCourses = new List<(int, char)>();

    //Constructor
    public Student(int id)
    {
        this.id=id;
    }

    //Methods
    public override void TaskToDo()
    {
        Console.WriteLine("Work on Homework");
    }
    public void AddCourse(int id, char grade = ' ')
    {
        currentCourses.Add((id, grade));
    }
    public void ClearCourses()
    {
        currentCourses.Clear();
    }
    public decimal CalculateGPA()
    {
        int totalCourses = currentCourses.Count;
        decimal totalGrades = 0;
        foreach (var course in currentCourses)
        {
            if (course.Item2 == 'A')
            {
                totalGrades += 1m;
            }
            else if (course.Item2 == 'B')
            {
                totalGrades += 0.75m;
            }
            else if (course.Item2 == 'C')
            {
                totalGrades += 0.5m;
            }
            else if (course.Item2 == 'D')
            {
                totalGrades += 0.25m;
            }
            else if (course.Item2 == 'F')
            {
                totalGrades += 0m;
            }
        }
        return (totalGrades / totalCourses) * 4;
    }
}
