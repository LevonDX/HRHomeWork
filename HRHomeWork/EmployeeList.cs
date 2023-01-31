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
    }
}
