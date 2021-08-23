using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Domain.Entities
{
    public class Planalto : BaseEntity
    {
        public Planalto(int x, int y)
        {
            this.Limite = new Coordenada { x = x, y = y };
            this.IdPlanalto = Guid.NewGuid().ToString();
            Sonda = new List<Sonda>();
        }
        public string IdPlanalto { get; set; }
        private Coordenada Limite { get;}
        public List<Sonda> Sonda { get; set; }
    }
}
