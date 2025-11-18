
#define TRACE_ENABLED

using System;
using System.Diagnostics;

namespace Conditional_Attribute_test_1
{

    public class AttributeTest
    {

        [Conditional("DEBUG")]
        public void DebugTest() {


            Console.WriteLine("This function executed in Debug");
        }


        [Conditional("TRACE_ENABLED")]
        public void LogTrace(string message)
        {
            Console.WriteLine($"[TRACE] {message}");
        }

        public void NormalFunc() {
          
            Console.WriteLine("this Is always Is executed");
             
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AttributeTest test = new AttributeTest();

            //this method is working just in Debug Mode
            test.DebugTest();

            //If don't defined TRACE_ENABLED You can't called LogTrace method
            test.LogTrace("This Trace message is only be included if TRACE_ENABLED defined   ");

            //this method is working always 
            test.NormalFunc();

        }
    }
}
