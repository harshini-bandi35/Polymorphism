/*5. Explain how Interfaces and Abstract Classes enable Polymorphism.
 * When should you use one over the other?
   **Estimated Time:** 8 minutes
Interface is basically a collection of classes, objects and methods. Interface contains only
abstract methods, an interface is created by using the interface keyword..in c# multiple inheritance is only possible in case of interface
abstraction:abstraction is a process of hiding the data but showing only functionality to
the user, which means when we define a method using abstract keyword we only declare a method, but don
not give any defination to that method...instead we give defination in the normal method.and in abstraction multiple inheritance is not possible.
the abstract class or method is created by using the abstract keyword, we cannot create an object to 
abstract class or an interface*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public abstract class AbstractClass
    {
        public abstract void Activity();
        public void Dance()
        {
            Console.WriteLine("I love to dance");
        }

    }
    public class FirstClass: AbstractClass
    {
        public override void Activity()
        {
            Console.WriteLine("I love to play");
        }
    }
    public class SecondClass : AbstractClass
    {
        public override void Activity()
        {
            Console.WriteLine("I love to sing");
        }
    }
}
