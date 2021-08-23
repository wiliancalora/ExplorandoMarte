using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marte.Services.Models
{
    public class SondaModel
    {
        public CoordenadaModel Coordenada { set; get; }
        public string Direcao { set; get; }
        public string Instrucoes { set; get; }
    }
}
