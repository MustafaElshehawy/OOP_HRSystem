namespace OOP_HRSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalarriedEmployee salariedEmployee = new SalarriedEmployee();
            salariedEmployee.BasicSalary = 2000;
            salariedEmployee.Housing = 1000;
            salariedEmployee.Transpoetation = 500;
            Console.WriteLine($"Salary of Salaried employee (witout taxes) is {salariedEmployee.GetSalary():0.00}");
            Console.WriteLine($"Salary of Salaried employee (with 30% taxes) is {salariedEmployee.GetSalary(30):0.00}");
            Console.WriteLine($"Salary of Salaried employee (with 30% taxes and 1500 bouns) is {salariedEmployee.GetSalary(30,1500):0.00}");
            
            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.HourRate = 100;
            hourlyEmployee.TotalWorkingHours = 60;
            Console.WriteLine($"Hourly of Salaried employee is {hourlyEmployee.GetSalary():0.00}");


            InternEmployee internEmployee = new InternEmployee();
            Console.WriteLine($"Intern of Salaried employee is {internEmployee.GetSalary():0.00}");

            Console.ReadKey();


            //Employee employee = new Employee();
            //employee.SetName("mostafa","Ahmed");
            //employee.BirthDate =new DateOnly(2025, 12, 24);
            //employee.BasicSalary = 5000;
            //employee.TaxPercentage = 140;

            //PrintPersonDetails(employee);
            //Console.WriteLine("----------------------");
            //Applicant applicant = new Applicant();
            //applicant.SetName("Ali", "Mohamed");
            //applicant.BirthDate = new DateOnly(2025, 12, 23);
            //PrintPersonDetails(applicant);

            //Console.WriteLine("----------------------");

            //Console.WriteLine($"Basic Salary :\t {employee.BasicSalary:0.00}"); //0.00 to put number ( 50 ==> 50.00 )     :c ==>$   
            //Console.WriteLine($"Tax Precentage :\t {employee.TaxPercentage}%");
            //Console.ReadKey();


            //void PrintPersonDetails(Person person)
            //{
            //    Console.WriteLine($"Full Name :\t {person.FirstName} {person.LastName}");
            //    Console.WriteLine($"Birth Date :\t {person.BirthDate}");
            //}

        }


    }
}
