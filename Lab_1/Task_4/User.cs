
namespace Task_4
{
    internal class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _date;

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Date { get; }

        public User(string lg, string fn, string ln, int ag)
        {
            _login = lg;
            _firstName = fn;
            _lastName = ln;
            _age = ag;
            _date = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        public void Display()
        {
            Console.WriteLine($"Login: {_login}\nFirst name: {_firstName}\nLast name: {_lastName}\nAge: {_age}\nAccount creation date: {_date}");
        }
    }
}



