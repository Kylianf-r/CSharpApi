using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        //Créer le constructeur
        static List<Joke> jokes;


        // GET: api/<JokesController>
        [HttpGet]
        public IActionResult JokeGet()
        {
            // Appel API Chuck Norris 
            var client = new HttpClient();
            var json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

            // Désérialisation du json de l'api
            var remoteJokes = JsonSerializer.Deserialize<List<string>>(json);

            // Return
            return Ok(jokes);
        }
        
        // GET api/<JokesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JokesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JokesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JokesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
