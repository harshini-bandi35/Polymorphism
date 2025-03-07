/*2. What is the difference between Compile-Time (Static)
 * and Run-Time (Dynamic) Polymorphism in C#? Provide Code Examples.

   **Estimated Time:** 7 minutes
   static-methodoverloading-compileTime
Dynamic-methodoverriding-runtime This is the example for Dynamic polymorphism */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class RunTime
    {
        public virtual void Addi(int a,int b)
        {
             Console.WriteLine("The addition of two numbers is: "+(a + b));
             
        }
    }
    public class Add : RunTime
    {
        public override void Addi(int a, int b)
        {
            Console.WriteLine("The addition of two number is: "+(a + b));
        }
    }

}
