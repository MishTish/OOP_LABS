

namespace Task_1
{
    internal class Address
    {

        private int _index;
        private string _country = "";
        private string _city = "";
        private string _street = "";
        private int _house;
        private int _apartment;

        public int Index
        { 
            get { return _index; }
            set { _index = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int House
        {
            get { return _house; }
            set { _house = value; }
        }
        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public void display()
        {
            Console.WriteLine($"Index: {Index} \nCountry: {Country} \nCity: {City} \nStreet: {Street} \nHouse: {House} \nApartment: {Apartment} \n");
        }
    }
}
