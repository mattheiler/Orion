using System.Collections.Generic;

namespace Orion.Entities
{
    public class Foo
    {
        public virtual int Id { get; private set; }

        public virtual User User { get; private set; }

        public virtual int UserId { get; private set; }

        public virtual ISet<Bar> Bars { get; } = new HashSet<Bar>();
    }
}