using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Final_Q9
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public override string ToString() => $"Name: {Name} - Species: {Species}";
        public abstract string HabitatLocation { get; set; }
    }
}
