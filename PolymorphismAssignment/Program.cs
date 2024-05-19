using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee();

            //Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            //Call the SayName method on the Employee object
            Employee employee = new Employee();
            employee.SayName();

            //Keep the console open
            Console.ReadLine();
        }
    }
}
