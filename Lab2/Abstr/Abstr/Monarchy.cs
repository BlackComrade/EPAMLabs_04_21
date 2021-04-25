using System;
using System.Collections.Generic;
using System.Text;

namespace Abstr
{
    class Monarchy: Polit
    {
        public int Number_in_the_world { get; set; }
        public Monarchy(string ruler, string elections, int degree_of_public_support): base( ruler,  elections,  degree_of_public_support)
        {
            this.Number_in_the_world = 52;
        }
        public override string TheySay()
        {
            return "За ВЕРУ, ЦАРЯ и ОТЕЧЕСТВО";
        }
    }
}
