using System.Collections.Generic;

namespace Orion
{
    public class Qux
    {
        public virtual int Id { get; private set; }

        public virtual ISet<BazQux> Bazes { get; } = new HashSet<BazQux>();
    }
}