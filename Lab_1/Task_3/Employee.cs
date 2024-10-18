

namespace Task_3
{
    internal class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _position = "Null";
        private int _employedMonths = 0;
        private double _salary = 0;
        private double _tax = 0;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public int EmployedMonths
        {
            get { return _employedMonths; }
            set { _employedMonths = value;}
        }
        
        
        public Employee(string firstName, string lastName) 
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        private void CalculateSalaryTax(string pos, double t)
        {
            if (pos == "Null")
            {
                _salary = 0;
                _tax = 0;
            }
            else if (pos == "Technician")
            {
                _salary = 50 + (t * 1);
                _tax = _salary * 0.1;
            }

            else if (pos == "Team lead")
            {
                _salary = 80 + (t * 0.8);
                _tax = _salary * 0.13;
            }

            else if (pos == "Manager")
            {
                _salary = 125 + (t * 0.5);
                _tax = _salary * 0.2;
            }
            else
            {
                _salary = 0;
            }

        }


        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Position: {_position}");
            Console.WriteLine($"Time employed: {_employedMonths} months");
            CalculateSalaryTax(_position, _employedMonths);
            Console.WriteLine($"Salary: {_salary:0.00} Robux");
            Console.WriteLine($"Tax: {_tax:0.00} Robux");
        }

    }
}
