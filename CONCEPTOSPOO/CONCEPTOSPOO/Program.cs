using CONCEPTOSPOO;

Console.WriteLine("CONCEPTOS POO");
Console.WriteLine("==============");

//instanciamos objeto
//guardamos la inpresion de las fechas en in try catch.

try
{
	Console.WriteLine(new cDate(2024, 2, 29));
	Console.WriteLine(new cDate(2004, 6, 9));
	Console.WriteLine(new cDate(1985, 18, 45));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}