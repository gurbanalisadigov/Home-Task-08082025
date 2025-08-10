using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 3)
                {
                    _name = value;
                }
                return;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {

                value = value.Trim();
                if (value.Length >= 3)
                {
                    _surname = value;
                }
                return;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0) ;
                _age = value;
            }
        }
        public Student(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
