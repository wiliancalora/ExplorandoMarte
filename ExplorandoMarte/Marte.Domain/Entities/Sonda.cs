using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Domain.Entities
{
    public class Sonda : BaseEntity
    {
        public Sonda(int x, int y, string direcao)
        {
            this.Coordenada = new Coordenada { x = x, y = y };
            this.IdSonda = Guid.NewGuid().ToString();
        }

        public string IdSonda { get; }
        public Coordenada Coordenada { get; }
        public string Direcao { get; }
        public string Instrucoes { get; set; }

    }
}
