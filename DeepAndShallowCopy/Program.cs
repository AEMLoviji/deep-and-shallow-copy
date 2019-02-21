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
                ReferenceTypeProperty = new DummyClassInternal() { ValueTypeProperty = "obj_1" },
                ListProperty = new List<int>() { 1, 2, 3 }
            };
            WriteToConsole("Original (before modification):\n\t{0}", original);

            Console.WriteLine();
            WriteToConsole("/// Creating Copies(Deep/Shallow) ///");
            Console.WriteLine();

            var shallowCopy = original.ShallowCopy();
            var deepCopy = original.DeepCopy();

            WriteToConsole("Shallow Copy - before modification: \n\t{0}", shallowCopy);
            WriteToConsole("Deep Copy - before modification: \n\t{0}", deepCopy);

            Console.WriteLine();
            WriteToConsole("/// Modifying Original now ///");
            Console.WriteLine();
            original.ListProperty[0] = 100;
            original.ValueTypeProperty = 2;
            original.ReferenceTypeProperty.ValueTypeProperty = "obj_2";

            WriteToConsole("Original (after modifying original): \n\t{0}", original);
            WriteToConsole("Shallow Copy (after modifying original): \n\t{0}", shallowCopy);
            WriteToConsole("Deep Copy (after modifying original): \n\t{0}", deepCopy);

            Console.ReadLine();
        }


        private static void WriteToConsole(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
    }
}
