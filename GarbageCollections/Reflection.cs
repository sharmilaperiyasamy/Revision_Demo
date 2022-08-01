using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollections
{
    internal class Reflection
    {
        public static void Reflect()
        {
            Type tp = typeof(System.Object);
            Console.WriteLine("Qualified assembly name:\n   {0}.", tp.AssemblyQualifiedName.ToString());
        }
    }
}
