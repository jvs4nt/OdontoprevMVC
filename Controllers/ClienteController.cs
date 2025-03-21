using Microsoft.AspNetCore.Mvc;
using OdontoprevApi.Models;
using OdontoprevApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OdontoprevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _service.GetAllAsync();
            return Ok(clientes);
        }

        // GET: api/Cliente/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(string id)
        {
            var cliente = await _service.GetByIdAsync(id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente([FromBody] Cliente cliente)
        {
            var createdCliente = await _service.CreateAsync(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = createdCliente.Id }, createdCliente);
        }

        // PUT: api/Cliente/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(string id, [FromBody] Cliente cliente)
        {
            if (id != cliente.Id)
                return BadRequest();

            await _service.UpdateAsync(cliente);
            return NoContent();
        }

        // DELETE: api/Cliente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(string id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}