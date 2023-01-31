using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRHomeWork
{
    class EmployeeList : IEnumerable<Employee>
    {
        private List<Employee> employees;

        public EmployeeList()
        {
            employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }

        /// <summary>
        /// returns employee by ID
        /// </summary>
        /// <param name="ID"></param>
        public Employee Get(int ID)
        {
            List<Employee> empls = this.employees.GetByCondition(e => e.ID == ID)
                .ToList();

            if(empls.Count != 1)
            {
                throw new Exception("invalid value for ID");
            }

            return empls[0];
        }

        public IEnumerable<Employee> Find(Predicate<Employee> predicate)
        {
            return this.employees.GetByCondition(predicate);
        }
    }
}
