using System;

var name = "Ewa";
var age = 33;
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
}
else if (age < 18)
    if (sex == 'm')
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }
    else

    {
        Console.WriteLine("Dane poza zakresem.");
    }


