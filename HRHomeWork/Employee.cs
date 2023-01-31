using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHomeWork
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public string ToFileString()
        {
            return $"{ID},{Name},{Surname}";
        }

        public static Employee Parse(string str)
        {
            // 1, John, Smith
            string[] strs = str.Split(',');

            if(strs.Length != 3)
            {
                throw new ArgumentException("Invalid input format");
            }

            int id = Int32.Parse(strs[0].Trim());
            string name = strs[1].Trim();
            string surname = strs[2].Trim();

            return new Employee()
            {
                ID = id,
                Name = name,
                Surname = surname
            };
        }
    }
}