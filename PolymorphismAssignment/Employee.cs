using System;

namespace PolymorphismAssignment
{
    //Create an Employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        //Implement the Quit method defined in the interface
        public void Quit()
        {
            Console.WriteLine("Employee quits the job.");
        }

        //Implement the SayName method required by the project
        public void SayName()
        {
            Console.WriteLine("Employee's name: David Beckham");
        }
    }
}
