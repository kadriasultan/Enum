using System;
public enum DayOfWeek
{
    Sanday=1,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
}

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Voer een nummer in van 1 tot 7 voor de dag van de week (1= zondag, 7= Zaterdag):");
    int dayInput = int.Parse(Console.ReadLine());

        if(Enum.IsDefined(typeof(DayOfWeek), dayInput))
        {
            DayOfWeek day = (DayOfWeek)dayInput;

            switch (day)
            {
               case DayOfWeek.Sanday:
                    Console.WriteLine("Zondag: tijd om te ontspannen!");
                    break;
                    case DayOfWeek.Monday:
                    Console.WriteLine("Maandag: een nieuwe week");
                    break;
                    case DayOfWeek.Tuesday:
                    Console.WriteLine("Dinsdag: blijf gefocust en productief");
                    break;
                    case DayOfWeek.Wednesday:
                    Console.WriteLine("Wonsdag: je bent halvewege de week!");
                    break;
                    case DayOfWeek.Thursday:
                    Console.WriteLine("Donderdag: Bijna weekend, houd vol!");
                    break;
                    case DayOfWeek.Friday:
                    Console.WriteLine("Vrijdag: Tijd om te ontspannen en het weekend te verwelkomen!");
                    break;
                    case DayOfWeek.Saturday:
                    Console.WriteLine("Zaterdag: Geniet van je weekend en laad jezelf op!");
                    break;

                default:
                    Console.WriteLine("ongeldige invoer");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ongeldige invoer. Voer een nummer in van 1 tot 7.");
        }
    
    }
}