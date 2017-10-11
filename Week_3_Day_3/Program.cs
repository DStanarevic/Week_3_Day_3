using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inhertiance, if two classes have a lot of the same code you can include that in one base class. (Squid and Octopus in class Cephlapod.)
            //Base Class, Class that will share it's fields and states with child classes.
            //Members - fields, Properties and Constructors. (Anything that is inside a class.)
            //public class ChildClass:ParentClass - This is how you would inherit the parent classes items. Each child class needs it's own constructor.
            //Child classes do no inherit the constructors from their base classes.
            //All items always inherit from system.object.

            //This object is created using the parent class.
            //Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);
            //baseVehicle.Move();
            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);

            Automobile herbie = new Automobile(4,13,2,4,1500,"White",88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile Distance Traveled " + herbie.DistanceTraveled);




        }
        

    }
}
