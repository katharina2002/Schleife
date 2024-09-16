/*
 * 13.07.2023 Katharina Wolf
 * Einfache Schleife
 */
Console.WriteLine("Wir zählen von 0 bis 20 hoch und wieder zurück auf 0");
Console.WriteLine("Wo starten wir?");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Wie weit zählen wir?");
int ende = Convert.ToInt32(Console.ReadLine());

int zahl = start;
while (zahl < ende)
{
    Console.WriteLine("{0}", zahl);
    zahl++;
}

int zahl2 = ende;
do
{
    Console.WriteLine("{0}", zahl2);
    zahl2--;
} while (zahl2 >= start);