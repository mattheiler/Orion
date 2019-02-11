namespace Orion
{
    public class BazQux
    {
        public virtual Baz Baz { get; private set; }

        public virtual int BazId { get; private set; }

        public virtual Qux Qux { get; private set; }

        public virtual int QuxId { get; private set; }
    }
}