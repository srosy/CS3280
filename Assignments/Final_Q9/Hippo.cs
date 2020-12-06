using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Q9
{
    public class Hippo : Animal
    {
        public override string HabitatLocation { get; set; }
        public bool IsHippo { get; set; }
        public virtual string NickName { get; set; }
    }
}
