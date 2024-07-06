using CONCEPTOSPOO;

Console.WriteLine("CONCEPTOS POO");
Console.WriteLine("==============");

CEmployee employee1 = new CSalaryEmployee()
{
    id = 1133,
    FirstName = "Damian",
    LastName = "Correa",
    BirthDate = new cDate(2004, 7, 8),
    HiringDate = new cDate(2023, 9, 15),
    IsActive = true,
    Salary = 1357000,
};
//Console.WriteLine(emplpyee1);

CEmployee employee2 = new CComissionEmployee()
{
    id = 1111,
    FirstName = "Isabella",
    LastName = "Perez",
    BirthDate = new cDate(2005, 4, 5),
    HiringDate = new cDate(2023, 4, 25),
    IsActive = true,
    ComissionPercentaje = 0.03F,
    sales = 320000000,
};
//Console.WriteLine(emplpyee2);

CEmployee employee3 = new CHoursEmployee()
{
    id = 4553,
    FirstName = "Jose",
    LastName = "Martinez",
    BirthDate = new cDate(1985, 6, 29),
    HiringDate = new cDate(2021, 5, 12),
    IsActive = true,
    HoursValue = 23000,
    Hours = 8,
};
//Console.WriteLine(emplpyee3);

CEmployee employee4 = new CBaseComissionEmployee()
{
    id = 2323,
    FirstName = "Diana",
    LastName = "Tusarma",
    BirthDate = new cDate(1995, 2, 2),
    HiringDate = new cDate(2011, 9, 29),
    IsActive = true,
    Base = 1000000,
    sales = 100000000,
    ComissionPercentaje = 0.01F,
};
//Console.WriteLine(employee4);

ICollection<CEmployee> employees = new List<CEmployee>()
{
    employee1, employee2, employee3, employee4
};

double PayRoll = 0;

foreach (CEmployee employee in employees)
{
    Console.WriteLine(employee);
    PayRoll += employee.GetValueToPay();
}
Console.WriteLine("                                    =================");
Console.WriteLine($"TOTAL:                             {$"{PayRoll:C2}", 18}");

CInvoice invoice1 = new CInvoice()
{
    Description = "Iphone 15 pro",
    ID = 133,
    Price = 5500000,
    Quantity = 5,

};

CInvoice invoice2 = new CInvoice()
{
    Description = "Costillas",
    ID = 123,
    Price = 120000,
    Quantity = 8.5F,
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);