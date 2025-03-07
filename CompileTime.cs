/*2.	2. What is the difference between Compile-Time (Static)
 * and Run-Time (Dynamic) Polymorphism in C#? Provide Code Examples.

   **Estimated Time:** 7 minutes
   static-methodoverloading-compileTime
Dynamic-methodoverriding-runtime This is the example for static polymorphism*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class CompileTime
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a,double b, double c)
        {
            return a + b + c;
        }

    }
}
