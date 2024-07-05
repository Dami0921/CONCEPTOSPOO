using CONCEPTOSPOO;

Console.WriteLine("CONCEPTOS POO");
Console.WriteLine("==============");

CEmployee emplpyee1 = new CSalaryEmployee()
{
    id = 1133,
    FirstName = "Damian",
    LastName = "Correa",
    BirthDate = new cDate(2004, 7, 8),
    HiringDate = new cDate(2023, 9, 15),
    IsActive = true,
    Salary = 1357000,
};
Console.WriteLine(emplpyee1);
CEmployee emplpyee2 = new CComissionEmployee()
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
Console.WriteLine(emplpyee2);