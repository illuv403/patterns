// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] arr)
        {
            var employees = new List<Employee>();

            for (int i = 0; i < arr.GetLength(0); i++)
                    employees.Add(new Employee(Int32.Parse(arr[i, 0]), arr[i, 1], arr[i, 2], Decimal.Parse(arr[i, 3])));

            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}
