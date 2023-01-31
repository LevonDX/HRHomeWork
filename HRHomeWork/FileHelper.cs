using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHomeWork
{
    class FileHelper
    {
        private const string FILENAME = "employees.txt";

        public void SaveToFile(EmployeeList employees)
        {
            using StreamWriter streamWriter = new StreamWriter(FILENAME);

            foreach (Employee item in employees)
            {
                streamWriter.WriteLine(item.ToFileString());
            }
        }

        public EmployeeList LoadFromFile()
        {
            using StreamReader streamReader = new StreamReader(FILENAME);
            EmployeeList employees = new EmployeeList();

            string str;
            while ((str = streamReader.ReadLine()) != null)
            {
                employees.Add(Employee.Parse(str));
            }

            return employees;
        }
    }
}
