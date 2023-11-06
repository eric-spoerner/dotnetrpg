using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetrpg.Models;

namespace dotnetrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterByID(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}