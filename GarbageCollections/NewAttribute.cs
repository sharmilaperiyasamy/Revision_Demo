using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace GarbageCollections
{
    class NewAttribute : Attribute
    {
        private string title;
        private string description;

        public NewAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of Class {0}", classType.Name);
            MethodInfo[] methods = classType.GetMethods();
            for(int i = 0; i < methods.Length; i++)
            {
                object[] attributeArray = methods[i].GetCustomAttributes(true);
                foreach(Attribute item in attributeArray)
                {
                    if(item is NewAttribute)
                    {
                        NewAttribute attributeobject = (NewAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name, attributeobject.title,
                            attributeobject.description);
                    }
                }
            }
        }
        public static void Annotat()
        {
            NewAttribute.AttributeDisplay(typeof(Employer));
            Console.WriteLine();
            NewAttribute.AttributeDisplay(typeof(Employee));
        }
    }
}
