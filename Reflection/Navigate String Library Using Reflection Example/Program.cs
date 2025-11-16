using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;


namespace Navigate_String_Library_Using_Reflection_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assembly mscorlib = typeof(string).Assembly;

            Type stringTypes = mscorlib.GetType("System.String");

            if (stringTypes != null) {

                Console.WriteLine($"Methods of the System.String class:\n");

                var stringMethods = stringTypes.GetMethods(BindingFlags.Public | BindingFlags.Static).OrderBy(method => method.Name);

                foreach (MethodInfo method in stringMethods) {


                    Console.WriteLine($"{method.ReturnType}  {method.Name} ("+GetParameterList(method.GetParameters())+ ")" );
                }


            }
        }

       static public string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));

        }
    }
}
