namespace HRHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper();
            EmployeeList employees = fileHelper.LoadFromFile();

            List<Employee> empls = employees.Find(e => e.Name.Contains('o'))
                .ToList();

            foreach (Employee item in empls)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Surname}");
            }
        }
    }
}