using Microsoft.AspNetCore.Mvc;
using OdontoprevApi.Models;
using OdontoprevApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedimentoController : ControllerBase
    {
        private readonly IProcedimentoService _service;

        public ProcedimentoController(IProcedimentoService service)
        {
            _service = service;
        }

        // GET: api/Procedimento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Procedimento>>> GetProcedimentos()
        {
            var procedimentos = await _service.GetAllAsync();
            return Ok(procedimentos);
        }

        // GET: api/Procedimento/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Procedimento>> GetProcedimento(string id)
        {
            var procedimento = await _service.GetByIdAsync(id);
            if (procedimento == null)
                return NotFound();
            return Ok(procedimento);
        }

        // POST: api/Procedimento
        [HttpPost]
        public async Task<ActionResult<Procedimento>> PostProcedimento([FromBody] Procedimento procedimento)
        {
            var createdProcedimento = await _service.CreateAsync(procedimento);
            return CreatedAtAction(nameof(GetProcedimento), new { id = createdProcedimento.Id }, createdProcedimento);
        }

        // PUT: api/Procedimento/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProcedimento(string id, [FromBody] Procedimento procedimento)
        {
            if (id != procedimento.Id)
                return BadRequest();

            await _service.UpdateAsync(procedimento);
            return NoContent();
        }

        // DELETE: api/Procedimento/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProcedimento(string id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
