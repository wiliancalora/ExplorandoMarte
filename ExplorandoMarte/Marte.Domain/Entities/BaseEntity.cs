using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marte.Domain.Entities
{
    public abstract class BaseEntity : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
