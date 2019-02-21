using System;

namespace DeepAndShallowCopy
{
    public class DummyClassInternal : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}";
        }
    }
}
