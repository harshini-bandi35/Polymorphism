/*7.	7. What happens if a Base Class method is not marked as 
 * `virtual` but a Derived Class defines a method with the same name? 
 * Explain with an Example.
   when we dont declare the base class method as virtual and we define the method with the same name 
and trying to override the method in the derived class then the method in the base class will be hidden
and will get an error saying cannot override the method in the base class without any keyword named
virtual.and if dont use to the override keyword and just use the same method as base class method then we cannot access the method in the derived class.
he new keyword in C# is used when a derived class has a method with the same
name as a method in the base class, but you don't want to override the base method. Instead, you want the new method in the derived class to hide the base class method.
If the base class method is not marked as virtual, and you don’t want to use method overriding, the new keyword can explicitly declare that the derived class is hiding the base method.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class BaseClass
    {
        public void Display()
        //public virtual void Display()
        {
            Console.WriteLine("This is the  class");
        }
    }
    public class DerivedClass:BaseClass
    {
        //public override void Display()
        public new void Display()
        {
            Console.WriteLine("This is the  class");
        }
        
    }
}
