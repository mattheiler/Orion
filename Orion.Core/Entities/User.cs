using System.Collections.Generic;

namespace Orion.Entities
{
    public class User
    {
        public virtual int Id { get; private set; }

        public virtual ISet<Foo> Foos { get; } = new HashSet<Foo>();
    }
}