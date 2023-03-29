
using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 0;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }

        [HttpGet]
        public IEnumerable<Filme> LerFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50)
        {
            return filmes.Skip(skip).Take(take); // skip pula quantos itens vc quer e take pega a qauntidade que vc quer.
        }

        [HttpGet("{id}")]
        public Filme? RecuperaFilmePorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }

    }
}
