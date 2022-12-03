using EmprestimoLivros.API.Controllers.NovaPasta;
using EmprestimoLivros.API.Interfaces;
using EmprestimoLivros.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteRepository.SelecionarTodos());

        }
    
    }
}
