using System.Collections.Generic;

namespace DeepAndShallowCopy
{
    public class DummyClass
    {
        public int ValueTypeProperty { get; set; }

        public DummyClassInternal ReferenceTypeProperty { get; set; }

        public List<int> ListProperty { get; set; }


        public DummyClass ShallowCopy()
        {
            return (DummyClass)MemberwiseClone();
        }

        public DummyClass DeepCopy()
        {
            DummyClass newDummyClass = (DummyClass)MemberwiseClone();
            newDummyClass.ListProperty = new List<int>(ListProperty);
            newDummyClass.ReferenceTypeProperty = (DummyClassInternal)newDummyClass.ReferenceTypeProperty.Clone();

            return newDummyClass;
        }

        public override string ToString()
        {
            return $"{nameof(ValueTypeProperty)}: {ValueTypeProperty}, {nameof(ReferenceTypeProperty)}: {ReferenceTypeProperty}, {nameof(ListProperty)}: {string.Join(",", ListProperty)}";
        }

    }
}
