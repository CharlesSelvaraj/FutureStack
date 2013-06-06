namespace FutureStack.DomainModel.Enums
{
    using System;

    public abstract class Enumeration
    {
        protected string Name;

        protected Enumeration(String name)
        {
            Name = name;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}