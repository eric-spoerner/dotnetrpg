using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterByID(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}