using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal hippo = new Hippo(); // hippo derives from abstract animal, which means it must inherit any abstract methods/properties
            hippo.HabitatLocation = "Amazon"; // the inherited property
            // abstract properties you must add to the inheriting class

            BabyHippo babyHippo = new BabyHippo(); // baby hippo derives from Hippo.
            babyHippo.NickName = "wittle baby hippo"; // setting the virtual property from Hippo.
            // virtual properties/methods are optional to add to the inheriting class. You can even override
            // and change the method/property for the inheriting class.

            //Polymorphism is when you need to change what object type to another.
            Hippo hippo2 = new BabyHippo();
            hippo2 = (BabyHippo)hippo2; // we have a hippo and now cast it to be a baby.
            //hippo2 = hippo2 as BabyHippo; // other way to cast
        }
    }
}
