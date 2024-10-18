//##### 1 #####

using Task_1;

Console.WriteLine("##### 1 ##### \n## Address ##\n");

Address someAddress = new Address();
someAddress.Index = 123456;
someAddress.Country = "USA";
someAddress.City = "New York";
someAddress.Street = "Bleeker st.";
someAddress.House = 391;
someAddress.Apartment = 7;


someAddress.display();