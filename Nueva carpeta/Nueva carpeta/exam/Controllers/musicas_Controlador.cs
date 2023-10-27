using exam.Models;
using Microsoft.AspNetCore.Mvc;
using exam.Context;

namespace exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class musicas_Controlador : ControllerBase
    {

        private readonly ILogger<musicas_Controlador> _logger;
        private readonly App_context _aplicacionContexto;
        public musicas_Controlador(
            ILogger<musicas_Controlador> logger,
            App_context aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Musica music)
        {
            _aplicacionContexto.musica.Add(music);
            _aplicacionContexto.SaveChanges();
            return Ok(music);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.musica.ToList());

        }
        [Route("/id")]
        [HttpPut]

        public IActionResult Put(
            [FromBody] Musica music)
        {
            _aplicacionContexto.musica.Update(music);

            _aplicacionContexto.SaveChanges();

            return Ok(music);
        }
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int id_MUSICA)
        {
            _aplicacionContexto.musica.Remove(

                _aplicacionContexto.musica.ToList()

                .Where(x => x.id_musica == id_MUSICA)
                .FirstOrDefault());

            _aplicacionContexto.SaveChanges();

            return Ok(id_MUSICA);
        }
    }
}
