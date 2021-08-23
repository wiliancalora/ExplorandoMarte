using Marte.Domain.Entities;
using Marte.Domain.Interfaces.Repositories;
using Marte.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Domain.Services
{
    public class SondaService : ServiceBase<Sonda>, ISondaService
    {
        readonly ISondaRepository _repository;

        public SondaService(ISondaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
