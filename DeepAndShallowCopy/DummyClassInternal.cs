using System;

namespace DeepAndShallowCopy
{
    public class DummyClassInternal : ICloneable
    {
        public string ValueTypeProperty { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{nameof(ValueTypeProperty)}: {ValueTypeProperty}";
        }
    }
}
