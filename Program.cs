// See https://aka.ms/new-console-template for more informati
Console.WriteLine("enter first name");
string firstName = Console.ReadLine();

Console.WriteLine("enter last name");
string lastName = Console.ReadLine();

Console.WriteLine("enter age");
int age =Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("enter favourite colour");
string favouritecolour = Console.ReadLine();

Console.WriteLine("enter  favourite food");
string favouritefood=Console.ReadLine();

Console.WriteLine("origin");
string origin = Console.ReadLine();
 
 
 
//interpolation
string interpolation=$"my name is {firstName} {lastName} I am {age} years old.\n my favourite colour is {favouritecolour} and my favourite food is {favouritefood}";
Console.WriteLine(interpolation);

Console.ReadKey();






