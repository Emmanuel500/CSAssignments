using System;
//School
//Interfaces
public interface ICourseService
{
    //Will have list of enrolled students
    public void EnrolledStudents();
}
public interface IDepartmentService
{
    //Will have one Instructor as head
    //Will have Budget for school year (start and end Date Time)
    public double BudegetForSchoolYear(DateTime start, DateTime end);
    //Will offer list of courses
    public void ListOfCourses();
}

//Concrete classes
public class Course : ICourseService
{
    //Field
    private int courseId;
    private string courseName;
    private List<int> studentsInCourse;

    //Constructore
    public Course(int courseId, string courseName = "")
    {
        this.courseId = courseId;
        this.courseName = courseName;
    }

    //Method
    public void AddStudentsInCourse(int studentId)
    {
        studentsInCourse.Add(studentId);
    }
    public void EnrolledStudents()
    {
        Console.WriteLine($"Students in {courseName} course");
        for (int s = 0; s < studentsInCourse.Count; s++)
        {
            Console.Write(studentsInCourse[s] + " ");
        }
    }

    //Properties
    public int CourseId { get { return courseId; } set { courseId = value; } }
    public string CourseName { get { return courseName; } set { courseName = value; } }
}

public class Department : IDepartmentService
{
    //Fields
    private int departmentId;
    private string departmentName;
    private int headId;
    private List<int> listOfCourses = new List<int>();

    //Contructor
    public Department (int departmentId, int headId, string departmentName = " ")
    {
        this.departmentId = departmentId;
        this.headId = headId;
        this.departmentName = departmentName;
    }

    //Methods
    public void AddCourse(int id)
    {
        listOfCourses.Add(id);
    }
    public void RemoveCourse(int id)
    {
        listOfCourses.Remove(id);
    }
    public double BudegetForSchoolYear(DateTime start, DateTime end)
    {
        return (end - start).TotalDays * 500;
    }
    public void ListOfCourses()
    {
        Console.WriteLine($"Courses ID in department: {departmentId}");
        foreach (int course in listOfCourses)
        {
            Console.WriteLine(course);
        }
    }

    //Properties
    public int DepartmentId { get { return departmentId; } set { departmentId = value; } }
    public string DepartmentName { get { return departmentName; } set { departmentName = value; } }
}