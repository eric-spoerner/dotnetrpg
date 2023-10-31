using System.Text.Json.Serialization;

namespace dotnetrpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Warrior = 1,
        Healer = 2,
        Paladin = 3,
        Goober = 4,
        Succubus = 5
    }
}