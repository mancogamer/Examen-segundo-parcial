using exam.Models;
using Microsoft.AspNetCore.Mvc;
using exam.Context;

namespace exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class discos_Controlador : ControllerBase
    {

        private readonly ILogger<discos_Controlador> _logger;
        private readonly App_context _aplicacionContexto;
        public discos_Controlador(
            ILogger<discos_Controlador> logger,
            App_context aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Disco disc)
        {
            _aplicacionContexto.disco.Add(disc);
            _aplicacionContexto.SaveChanges();
            return Ok(disc);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.disco.ToList());

        }
        [Route("/id")]
        [HttpPut]

        public IActionResult Put(
            [FromBody] Disco disc)
        {
            _aplicacionContexto.disco.Update(disc);

            _aplicacionContexto.SaveChanges();

            return Ok(disc);
        }
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int id_DISCO)
        {
            _aplicacionContexto.disco.Remove(

                _aplicacionContexto.disco.ToList()

                .Where(x => x.id_disco == id_DISCO)
                .FirstOrDefault());

            _aplicacionContexto.SaveChanges();

            return Ok(id_DISCO);
        }
    }
}
