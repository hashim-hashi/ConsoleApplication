using System;

namespace EmployeeSalaryTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            Console.WriteLine("Employee Name : ");
            string Name = Console.ReadLine();

            Console.WriteLine("Basic Salary : ");
            double BasicSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Number of days worked in a month : ");
            int DaysWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("HRA Percentage : ");
            double HraPercent = double.Parse(Console.ReadLine());

            Console.WriteLine("Conveyance Allowance Amount: ");
            double ConveyanceAllowance = double.Parse(Console.ReadLine());

            Console.WriteLine("Medical Allowance Amount: ");
            double MedicalAllowance = double.Parse(Console.ReadLine());

            // Salary
            double Salary = BasicSalary * (DaysWorked/30);

            // Taxable Income
            double Exemptions = (Salary * HraPercent / 100) + ConveyanceAllowance + MedicalAllowance;
            double TaxableIncome = Salary - Exemptions;

            // Tax Amount
            double Tax = 0;
            if (TaxableIncome <= 250000)
            {
                Tax = 0;
            }
            else if (TaxableIncome > 250000 && TaxableIncome <= 500000)
            {
                Tax = (TaxableIncome - 250000) * 0.05;
            }
            else if (TaxableIncome > 500000 && TaxableIncome <= 1000000)
            {
                Tax = 12500 + (TaxableIncome - 500000) * 0.2;
            }
            else if (TaxableIncome > 1000000)
            {
                Tax = 112500 + (TaxableIncome - 1000000) * 0.3;
            }

            // Output
            Console.WriteLine("Output");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Taxable Income: " + TaxableIncome);
            Console.WriteLine("Tax Amount: " + Tax);
        }
    }
}
