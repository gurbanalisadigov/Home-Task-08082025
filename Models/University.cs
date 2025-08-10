using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_08082025.Models
{
    internal class University
    {
        private string _name;
        Group[] _groups = new Group[0];

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
        public Group[] Groups
        {
            get
            {
                return _groups;
            }
            set
            {
                _groups = value;
            }
        }
        public University()
        {
            _groups = new Group[0];
        }
        public void AddGroup(Group groups)
        {
            Array.Resize(ref _groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = groups;
        }
        public void RemoveGroup(string name)
        {
            Group[] newGroups = new Group[Groups.Length - 1];
            int j = 0;
            bool found = false;

            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].Name != name)
                {
                    newGroups[j] = Groups[i];
                    j++;
                }
                else
                {
                    found = true;
                }
            }
            if (found)
            {
                _groups= newGroups;
                Console.WriteLine($"{name} adli qrup silindi");
            }
            else
            {
                Console.WriteLine($"{name} adli qrup tapilmadi");
            }
        }
        public void ShowGroups(string Groups)
        {
            if (Groups.Length > 0)

                for (int i = 0; i < Groups.Length; i++)
                {
                    Console.WriteLine($"{Groups} adli qrup movcuddur");

                }
            else
            {
                Console.WriteLine($"Bele bir qrup yoxdur");
            }
        }
        public void ShowAllStudents(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)

            {
                Console.WriteLine($"{groups[i].Name}");

                for (int j = 0; j < groups[i].Students.Length; j++)
                {
                    Console.WriteLine($"- {groups[i].Students[j].Name}");
                }
            }
        }
    }
}
