using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetrpg.Models;
using dotnetrpg.Dtos.Character;

namespace dotnetrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterByID(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);    
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);  
    }
}