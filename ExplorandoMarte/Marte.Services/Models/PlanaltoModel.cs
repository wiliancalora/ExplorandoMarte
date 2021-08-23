using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marte.Services.Models
{
    public class PlanaltoModel
    {
        public CoordenadaModel Limite { get; set; }
        public List<SondaModel> Sonda { get; set; }
    }
}
