using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace InheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          string[] lines = File_Reader.ReadAllEmployees();

            
            List<Wages> wages = new List<Wages>();
            List<Salaried> salaried = new List<Salaried>();
            List<Part_time> parttimer = new List<Part_time>();

            
            foreach (string line in lines)
            {
                
                string[] words = line.Split(':');

                
                if (words[0].StartsWith("5") ||
                    words[0].StartsWith("6") ||
                    words[0].StartsWith("7"))
                {

                    
                    long sin = long.Parse(words[4]);
                    double rate = double.Parse(words[7]);
                    double hours = double.Parse(words[8]);

                    
                    Wages wage = new Wages(words[0],
                        words[1],
                        words[2],
                        words[3],
                        sin,
                        words[5],
                        words[6],
                        rate,
                        hours);

                    
                    wages.Add(wage);
                }

                else if (words[0].StartsWith("0") ||
                    words[0].StartsWith("1") ||
                    words[0].StartsWith("2") ||
                    words[0].StartsWith("3") ||
                    words[0].StartsWith("4"))
                {
                    double salary = double.Parse(words[7]);
                    long sin = long.Parse(words[4]);

                    Salaried salaries = new Salaried(words[0],
                        words[1],
                        words[2],
                        words[3],
                        sin,
                        words[5],
                        words[6],
                        salary);
                    salaried.Add(salaries);
                }

                else if (words[0].StartsWith("8") ||
                    words[0].StartsWith("9"))
                {
                    long sin = long.Parse(words[4]);
                    double rate = double.Parse(words[7]);
                    double hours = double.Parse(words[8]);

                    Part_time parttime = new Part_time(words[0],
                        words[1],
                        words[2],
                        words[3],
                        sin,
                        words[5],
                        words[6],
                        rate,
                        hours);

                    parttimer.Add(parttime);

                }
            }

            


            double totalWeeklyWagePay = wages.Sum(w => w.getPay());
            double totalWeeklySalariedPay = salaried.Sum(s => s.getPay());
            double totalWeeklyPartTimePay = parttimer.Sum(p => p.getPay());
            double totalEmployees = wages.Count() + salaried.Count() + parttimer.Count();

            double averageWeeklyEmployeePay = (totalWeeklyWagePay
                + totalWeeklySalariedPay + totalWeeklyPartTimePay) / 9; 


            
            double highestWeeklyWagePay = wages.Max(w => w.getPay());
            double lowestSalaryPay = salaried.Min(s => s.getPay());

            
            Wages highestPaidWageEmployee = wages.FirstOrDefault(w => w.getPay() == highestWeeklyWagePay);
            Salaried lowestPaidSalaryEmployee = salaried.FirstOrDefault(s => s.getPay() == lowestSalaryPay);

            double numOfWageEmployees = wages.Count();
            double numOfSalariedEmployees = salaried.Count();
            double numOfPartTimeEmployees = parttimer.Count();

            double percentageOfWageEmployees = numOfWageEmployees / totalEmployees * 100;
            double percentageOfSalariedEmployees = numOfSalariedEmployees / totalEmployees * 100;
            double percentageOfPartTimeEmployees = numOfPartTimeEmployees / totalEmployees * 100;


            

            Console.WriteLine($"The average weekly pay for all employees: ${averageWeeklyEmployeePay}\n");

            Console.WriteLine($"The highest weekly pay for a wage employee is " +
                $"{highestPaidWageEmployee.Name} with a weekly salary of ${highestWeeklyWagePay}\n");

            Console.WriteLine($"The lowest paid salary employee is " +
                $"{lowestPaidSalaryEmployee.Name} with a salary of ${lowestSalaryPay}\n");

            Console.WriteLine($"Wage Employees take up {percentageOfWageEmployees}% of Employees\n" +
                $"Salaried Employees take up {percentageOfSalariedEmployees}% of Employees\n" +
                $"Part Time Employees take up {percentageOfPartTimeEmployees}% of Employees");

            Console.ReadKey();


        }
    }
}
