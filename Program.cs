using Home_Task_08082025.Models;

namespace Home_Task_08082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Qurbanali", "Sadigov", 25);

             student.PrintInfo();
            student.Name = "Ayxan";
            student.Surname = "Sadiqli";
            student.Age = 24;
            student.PrintInfo();

            Group group = new Group();
            group.AddStudents(student);
            group.Remove(_students);


            
        }
    }
}
