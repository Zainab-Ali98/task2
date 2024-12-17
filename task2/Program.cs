// See https://aka.ms/new-console-template for more information
//1

using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Timers;

Console.WriteLine("eneter name");
 
string name= Console.ReadLine();

Console.WriteLine("enter language");
string language = Console.ReadLine();

if( language == "en")
{
    Console.WriteLine("Hello " + name);
}

else if (language == "es")
{
    Console.WriteLine("hola" + name);

}
else if(language== "fr")
{
    Console.WriteLine("Bonjor" + name);

}

else if(language== "tr")
{
    Console.WriteLine("Merhaba" + name);
}

//2
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x is bigger");
}
else 
{
    Console.WriteLine("y is bigger");
}

//3
double mark = Convert.ToDouble(Console.ReadLine());
if (mark >= 80)
{
    Console.WriteLine("A");
}
else if (mark >= 70 && mark < 80)
{
    Console.WriteLine("B");
}
else if (mark >= 60 && mark < 70)
{
    Console.WriteLine("C");
}
else if (mark >= 50 && mark < 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}