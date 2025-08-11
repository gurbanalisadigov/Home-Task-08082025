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
                if (value.Length > 0)
                {
                    _company = value;
                }
                return;
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
                if (_salaryperhour > 0)
                {
                    _salaryperhour = value;
                }
                return;
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
                if (_hours > 0)
                {
                    _hours = value;
                }

                return;
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
                if (_experience > 0)
                {
                    _experience = value;
                    return;
                }
               
            }
        }
        public Employee(string name, string surname, string company, decimal salaryperhour, double hours, int experience):base(name, surname)
        {
                         
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
}
