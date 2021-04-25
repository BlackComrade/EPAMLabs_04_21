using System;
using System.Collections.Generic;
using System.Text;

namespace Abstr
{
    abstract class Polit
    {
       public string Ruler { get; set; }
       public string Elections { get; set; }
       public int Degree_of_public_support { get; set; }
        
       public Polit (string ruler, string elections, int degree_of_public_support)
        {
            this.Ruler = ruler;
            this.Elections = elections;
            this.Degree_of_public_support = degree_of_public_support;
        }

       public abstract string TheySay();
    }
}
