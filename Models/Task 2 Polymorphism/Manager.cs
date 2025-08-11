using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models.Task_2_Polymorphism
{
    internal class Manager : Employee
    {
        private decimal _bonus;

        public decimal Bonus
        {
            get
            {
                return _bonus;
            }
            set
            {
                _bonus = value;
            }
        }

        public Manager(string name, string surname, string company, decimal salaryperhour, double hours, int experience, decimal bonus)
            : base(name, surname, company, salaryperhour, hours, experience)
        {
           
            _bonus = bonus;


        }
        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            double bonusAmount = baseSalary *(double) _bonus / 100;
            return(baseSalary + bonusAmount);
        }
        
    }
}
