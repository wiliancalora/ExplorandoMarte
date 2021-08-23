using Marte.Application.Interfaces;
using Marte.Domain.Entities;
using Marte.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marte.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplorarController : ControllerBase
    {
        private readonly ILogger<ExplorarController> _logger;
        private readonly IExplorarAppService _explorarAppService;

        public ExplorarController(ILogger<ExplorarController> logger,
                                  IExplorarAppService explorarAppService)
        {
            _logger = logger;
            _explorarAppService = explorarAppService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PlanaltoModel planaltoModel)
        {
            try
            {
                _logger.LogInformation("Action Post :: UserController -> execute"
                       + DateTime.Now.ToLongTimeString());


                //Planalto planalto = new Planalto(5, 5);

                //planalto.Sonda.Add(new Sonda(3, 3, 1));
                //planalto.Sonda.FirstOrDefault().Instrucoes = "MMMMMMMMM";

                //planalto.Sonda.Add(new Sonda(, 2, 0));
                //planalto.Sonda.FirstOrDefault().Instrucoes = "LMLMLMLMM";

                var resultado = _explorarAppService.Explorar(planalto);

                return StatusCode(StatusCodes.Status200OK, resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }
    }
}
