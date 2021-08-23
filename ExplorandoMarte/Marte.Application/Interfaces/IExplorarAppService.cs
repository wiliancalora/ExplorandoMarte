using Marte.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Application.Interfaces
{
    public interface IExplorarAppService
    {
        string Explorar(Planalto planalto);
    }
}
