var name = "Arek";
char gender = 'm';
var age = 17;

if (age < 30 && gender == 'w')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" &&age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Zwierzę jakieś");
}