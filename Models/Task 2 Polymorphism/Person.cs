using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models.Task_2_Polymorphism
{
    internal class Person
    {
        public string _name;
        public string _surname;

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                value =value.Trim();
                if (value.Length >= 3)
                {
                    _name = value;
                }
                
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
                value=value.Trim();
                if (value.Length >= 3)
                {
                    _surname = value;
                }
            }
        }

        public Person(string name, string surname)
        {
            _name = Name;
            _surname = Surname;
        }

        public override string ToString()
        {

            return _name + " " + _surname;
        }
    }
}
