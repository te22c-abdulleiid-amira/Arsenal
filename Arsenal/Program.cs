using System.Text.Json;

string weaponText = File.ReadAllText(@"weapon.json");

Weapon MyNewWeapon = JsonSerializer.Deserialize<Weapon>(weaponText);

Console.WriteLine("hur mycket skada?");

int numAttacks = 0;
string numAttacksStr = "2";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
    numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.Red;


Console.ResetColor();

Console.WriteLine("zoinks");

Console.ReadLine();

// Weapon weapon = new Weapon() {
//     Name = "diavolo"
// };

// string json = JsonSerializer.Serialize<Weapon>(weapon);

// File.WriteAllText(@"weapon.json", json);