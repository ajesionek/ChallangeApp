/* 
int[] grades = new int[365];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";

for (int i=0; i<dayOfWeeks.Length; i=i+2)
{
    Console.WriteLine(dayOfWeeks[i]);
}

string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

Console.WriteLine(dayOfWeeks[2]);


List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}


for (int i = 0; i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
*/

int number = 123864594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Ile razy dana cyfra występuję w liczbie " + number + ":");
Console.WriteLine("iość wystąpień cyfry 0: " + counter0);
Console.WriteLine("iość wystąpień cyfry 1: " + counter1);
Console.WriteLine("iość wystąpień cyfry 2: " + counter2);
Console.WriteLine("iość wystąpień cyfry 3: " + counter3);
Console.WriteLine("iość wystąpień cyfry 4: " + counter4);
Console.WriteLine("iość wystąpień cyfry 5: " + counter5);
Console.WriteLine("iość wystąpień cyfry 6: " + counter6);
Console.WriteLine("iość wystąpień cyfry 7: " + counter7);
Console.WriteLine("iość wystąpień cyfry 8: " + counter8);
Console.WriteLine("iość wystąpień cyfry 9: " + counter9);