using System;

var name = "Czesław";
var age = 50;
var sex = 'f';
//f - female, m - male; l - lgbt;

if (sex == 'f')
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa lat 33.");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");
    }
    else
    {
        Console.WriteLine("Inna kobieta 30-letnia lub starsza.");
    }
}
else if (age < 18 && sex == 'm')

{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else

{
    Console.WriteLine("Dane poza zakresem.");
}


