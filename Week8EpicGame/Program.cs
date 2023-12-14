string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] villains = { "Venom", "Hao Asakura", "Megatron", "Thanos", "Darth Vader", "Plankton" };
//string[] heroes = { "Deadpool", "Captain Price", "Optimus Prime", "John Wick", "Witcher" };

string[] weapon = { "magic wand", "banana", "Thompson submachine gun", "Desert Eagle", "Lightsaber", "A cat", "Novichok" };

//Random rnd = new Random();
//int randomIndex = rnd.Next(0, heroes.Length);
//string hero = heroes[randomIndex];
//Console.WriteLine($"Today {hero} saves your ass!");

//randomIndex = rnd.Next(0, villains.Length);

//string villain = villains[randomIndex];
//Console.WriteLine($"Today {villain} tries to take over the world!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"But {hero} will save your ass with his {heroWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}