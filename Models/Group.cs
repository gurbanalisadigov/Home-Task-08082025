using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models
{
    internal class Group
    {
        private string _name;
        private int _groupLimit;
        Student[] _students = new Student[0];
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int GroupLimit
        {
            get
            {
                return _groupLimit;
            }
            set
            {
                _groupLimit = value;
            }
        }
        public Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }

        public void AddStudents(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void Remove(string name)
        {
            Student[] newStudent = new Student[Students.Length - 1];
            int j = 0;

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name != name)
                {
                    newStudent[j] = Students[i];
                }
                j++;
            }

        }
        public bool StudentExists(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)

                    Console.WriteLine("Bu adda telebe movcuddur");
                return true;
            }
            return false;

        }
        public void ShowStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].PrintInfo();
            }

        }
       

    }
}
