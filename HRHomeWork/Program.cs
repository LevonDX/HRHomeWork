namespace HRHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHelper fileHelper = new FileHelper();
            EmployeeList employees = fileHelper.LoadFromFile();

            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Surname}");
            }
        }
    }
}