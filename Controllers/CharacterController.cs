using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        
        // public static Character knight = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1,Name = "Sam" },
        };
        [HttpGet("")]
        public IActionResult Get(){
            return Ok(characters);
        }
        [HttpGet("{id}")]
        public IActionResult GetFirstCharacter(int id) => Ok(characters.FirstOrDefault(c => c.Id == id));

        [HttpPost("")]
        public IActionResult AddCharacter(Character character){
            characters.Add(character);
            return Ok(characters);
        }
    }
}