using System;
using System.Collections.Generic;

namespace DeepAndShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = new DummyClass
            {
                ValueTypeProperty = 1,
                ReferenceTypeProperty = new DummyClassInternal() { Name = "obj_1" },
                ListProperty = new List<int>() { 1, 2, 3 }
            };
            Console.WriteLine("Original (before modification):\n\t{0}", original);

            Console.WriteLine();
            Console.WriteLine("/// Creating Copies(Deep/Shallow) ///");
            Console.WriteLine();

            DummyClass shallowCopy = original.ShallowCopy();
            DummyClass deepCopy = original.DeepCopy();

            Console.WriteLine("Shallow Copy - before modification: \n\t{0}", shallowCopy);
            Console.WriteLine("Deep Copy - before modification: \n\t{0}", deepCopy);

            Console.WriteLine();
            Console.WriteLine("/// Modifying Original now ///");
            Console.WriteLine();
            original.ListProperty[0] = 999;
            original.ValueTypeProperty = 2;
            original.ReferenceTypeProperty.Name = "obj_2";

            Console.WriteLine("Original (after modifying original): \n\t{0}", original);
            Console.WriteLine("Shallow Copy (after modifying original): \n\t{0}", shallowCopy);
            Console.WriteLine("Deep Copy (after modifying original): \n\t{0}", deepCopy);

            Console.ReadLine();
        }
    }
}
