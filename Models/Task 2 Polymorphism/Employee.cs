using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models.Task_2_Polymorphism
{
    internal class Employee:Person
    {
        private string _company;
        private decimal _salaryperhour;
        private double _hours;
        private int _experience;

        public string Company
        {
            get
            {
                return _company;

            }
            set
            {
                _company = value;
            }
        }
        public decimal SalaryPerHour
        {
            get
            {
                return _salaryperhour;

            }
            set
            {
                _salaryperhour = value;

            }
        }
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
            }
        }
        public Employee(string name, string surname, string company, decimal salaryperhour, double hours, int experience):base(name, surname)
        {
              _name= name;
            _surname= surname;            
            _company = company;
            _salaryperhour = salaryperhour;
            _hours = hours;
            _experience = experience;
        }
        public virtual double CalculateSalary()
        {
            double salary = (double)_salaryperhour * _hours;
            return salary;
           

        

    }
}
