using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    public int DamageMax = 20;

    [JsonInclude]
    public int DamageMin = 5;

    public void Attack()
    {
        Random.Shared.Next(DamageMin, DamageMax);
    }
}
