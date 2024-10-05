// See https://aka.ms/new-console-template for more information
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

// veraiebles ---> camelCase
bool isAuthenicated = false;
Console.WriteLine(message1);

//condition
if (isAuthenicated)
{
    Console.WriteLine("Buton --> Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton --> Sisteme giriş yap");
}

Console.WriteLine("Kod dizilimi bitti");

string[] leans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5", "kredi 6" };
//string[] leans2 = new string[6];
//leans2[0] = "kredi 1";

     //start       condition    //increment
for (int i = 0; i < leans.Length; i++)
{
    Console.WriteLine(leans[i]);
}

// course[] courses = { course1, course2, course3 };

CourseManager courseManager = new CourseManager();

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

int number1 = 10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value types -->int, bool,double...
//reference types --> array, class, interface...
//101        //102     //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}