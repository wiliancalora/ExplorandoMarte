using Marte.Application.Interfaces;
using Marte.Domain.Entities;
using Marte.Domain.Interfaces.Services;
using Marte.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Application
{
    public class SondaAppService : AppServiceBase<Sonda>, ISondaAppService
    {
        readonly ISondaService _sondaService;

        public SondaAppService(ISondaService sondaService) : base(sondaService)
        {
            _sondaService = sondaService;
        }

    }
}
