List<Eruption> eruptions = new()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
    };
// Example Query - Prints all Stratovolcano eruptions
List<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano").ToList();
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// TASK 1
Eruption? FirstChileVolcano = eruptions.FirstOrDefault(town => town.Location == "Chile");
// Console.WriteLine(FirstChileVolcano);

// TASK 2
Eruption? FirstHawaiianIs = eruptions.FirstOrDefault(town => town.Location == "Hawaiian Is");
// if (FirstHawaiianIs == null)
// {
//     Console.WriteLine("No Eruption Found");
// }
// else
// {
//     Console.WriteLine(FirstHawaiianIs);
// }

// TASK 3
Eruption? FirstGreenland = eruptions.FirstOrDefault(town => town.Location == "Greenland");
// if (FirstGreenland == null)
// {
//     Console.WriteLine("No Greenland Eruption Found");
// }
// else
// {
//     Console.WriteLine(FirstGreenland);
// }

// TASK 4
Eruption? InNewZealand = eruptions.Where(t => t.Year >= 1900).FirstOrDefault(t => t.Location == "New Zealand");
// Console.WriteLine(InNewZealand);

// TASK 5
IEnumerable<Eruption> VolElevation = eruptions.Where(t => t.ElevationInMeters >= 2000);
// PrintEach(VolElevation, "Volcano over 2000");

// TASK 6
IEnumerable<Eruption> VolName = eruptions.Where(t => t.Volcano[0] == 'L');
// PrintEach(VolName, "All Volcanos that start with L");

// TASK 7
int BiggestElevation = eruptions.Max(t => t.ElevationInMeters);
// Console.WriteLine(BiggestElevation);

// TASK 8 
Eruption? BiggestVol = eruptions.FirstOrDefault(t => t.ElevationInMeters == BiggestElevation);
// Console.WriteLine(BiggestVol.Volcano);

// TASK 9 
List<Eruption> AlphabVol = eruptions.OrderBy(t => t.Volcano).ToList();
// PrintEach(AlphabVol, "Alphabetical Order");

// TASK 10 
int SumOfAll = eruptions.Sum(t => t.ElevationInMeters);
Console.WriteLine(SumOfAll);

// TASK 11
bool EruptedVols = eruptions.Any(t => t.Year == 2000);
// Console.WriteLine(EruptedVols);

//TASK 12
List<Eruption> Strats = eruptions.Where(t => t.Type == "Stratovolcano").Take(3).ToList();
// PrintEach(Strats, "First 3 Stratovolcanos");

// TASK 13
List<Eruption> OldVols = eruptions.Where(t => t.Year <= 1000).OrderBy(t => t.Volcano).ToList();
PrintEach(OldVols, "Really old volcanos alphabetically");

// TASK 14
List<string> OldVolsNames = eruptions.Where(t => t.Year <= 1000).OrderBy(t => t.Volcano).Select(t => t.Volcano).ToList();
foreach (string name in OldVolsNames)
{
    Console.WriteLine(name);
}








// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
