using System.Collections.Generic;

namespace Orion.Entities
{
    public class Baz
    {
        public virtual Bar Bar { get; private set; }

        public virtual int BarId { get; private set; }

        public virtual ISet<BazQux> Quxes { get; } = new HashSet<BazQux>();
    }
}