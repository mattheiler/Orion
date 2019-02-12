using System.Collections.Generic;

namespace Orion.Models
{
    public class Bar
    {
        public virtual int Id { get; private set; }

        public virtual Foo Foo { get; private set; }

        public virtual int FooId { get; private set; }

        public virtual Baz Baz { get; private set; }

        public virtual Bar Parent { get; private set; }

        public virtual int? ParentId { get; private set; }

        public virtual ISet<Bar> Children { get; } = new HashSet<Bar>();
    }
}