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
                                  IExplorarAppService explorarAppService
                                 )
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

                //Mapeamento do objeto de entrada
                Planalto planalto = new Planalto(planaltoModel.Limite.x, planaltoModel.Limite.y);
                foreach (var sondaModel in planaltoModel.Sonda)
                {
                    var sonda = new Sonda(sondaModel.Coordenada.x, sondaModel.Coordenada.y, (int)(Enum.Parse(typeof(Sonda.Dir),sondaModel.Direcao)));
                    sonda.Instrucoes = sondaModel.Instrucoes;
                    planalto.Sonda.Add(sonda);
                }
                
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
