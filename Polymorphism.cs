/*Polymorphism enhances code maintainability and extensibility by allowing developers to write more flexible, reusable, and modular code. It enables a single interface to handle different types of objects, reducing redundancy and promoting scalability.
Centralized Code Changes: When the base class contains shared methods, updates can be made in one place without modifying derived classes.
Reduced Redundancy: By using a common base class or interface, you avoid duplicating code.
Easier Bug Fixes: Code is easier to debug and maintain because behavior depends on a predictable interface rather than specific implementations.

Dynamic Behavior: New derived classes can be added without altering existing code, as long as they conform to the base class or interface.

Scalable Design: Code using polymorphic behavior (e.g., method overriding) can seamlessly adapt to new functionality.
*/
using System;
using System.Collections.Generic;

namespace PolymorphismExample
{
    // Base class
    public abstract class PaymentProcessor
    {
        public abstract void ProcessPayment(decimal amount);
    }

    // Derived class for Credit Card
    public class CreditCardProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }
    }

    // Derived class for UPI
    public class UPIProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount:C}.");
        }
    }

    // Derived class for PayPal
    public class PayPalProcessor : PaymentProcessor
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}.");
        }
    }
}