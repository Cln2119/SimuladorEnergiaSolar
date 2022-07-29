using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Domain.Interfaces;

namespace Api.Application.Controllers
{

    [Route("simulador")]
    [ApiController]
    public class SimuladorController : ControllerBase
    {

        Simulacao valoresSimulacao = new Simulacao();
        public ISimulacaoService _service { get; set; }
        

        public SimuladorController(ISimulacaoService service)
        {
            _service = service;
            
        }
       



        [Route("ResultadoSimulacao")]
        [HttpGet]
        public async Task<IActionResult> GetValor([FromBody] Simulacao valor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var RetornoDadosSimulacao = await _service.GetAll();
                var resultadoDadosSimulacao = RetornoDadosSimulacao.Where(x => x.Media_Valor_Mensal == valor.Media_Valor_Mensal).ToList();    
                return Ok(resultadoDadosSimulacao); 
             
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

            
        }
      

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Simulacao user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(user);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

      
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

         
        }
    }
}
