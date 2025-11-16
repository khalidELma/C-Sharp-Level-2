using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Example_2___Dynamically_Create_Objects_and_Invoke_Methods
{
   
    internal class Program
    {
        public class MyClass
        {
            public int Property { get; set; }
            public int Property1 { get; set; }
      
            public void Method1()
            {
                Console.WriteLine("Hi, I'm Method 1");
            }
            public void Method2(int Num, int Num2)
            {

                Console.WriteLine($"Hi, I'm Method 2 and I have Value = {Num} and {Num2}");
            }
        }
        static void Main(string[] args)
        {
            Type MyClassType = typeof(MyClass);

            Console.WriteLine($"Type Name : {MyClassType.Name}");
            Console.WriteLine($"Full Name : {MyClassType.FullName}");

            //get all property 

            foreach (var Property in MyClassType.GetProperties())
            {
                Console.WriteLine("Property Name " + Property.Name + ",Type " + Property.PropertyType);

            }

            Console.WriteLine("\n\n\n\n\n");

            //get all Method

            foreach (var method in MyClassType.GetMethods())
            {
                Console.WriteLine($"Method Type : {method.ReturnType}  {method.Name}({GetParameters(method.GetParameters())}) ");
            }


            object MyClassInstans = Activator.CreateInstance(MyClassType);

            MyClassType.GetProperty("Property1").SetValue(MyClassInstans, 24);
            MyClassType.GetProperty("Property").SetValue(MyClassInstans, 30);
           
            object[] Parameters = { (int)MyClassType.GetProperty("Property1").GetValue(MyClassInstans)
                     , (int)MyClassType.GetProperty("Property").GetValue(MyClassInstans) };

            MyClassType.GetMethod("Method1").Invoke(MyClassInstans, null);
            MyClassType.GetMethod("Method2").Invoke(MyClassInstans, Parameters);
        }

        static public string GetParameters(ParameterInfo[] parameters)
        {
            return string.Join(",", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }
}
