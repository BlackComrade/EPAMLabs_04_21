using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Islam : Religion
    {
        public string Jihad { get;}
        public Islam(ulong number_of_followers, string holy_Bible, string key_person, string name = "Ислам") : base(name, number_of_followers, holy_Bible, key_person)
        {
            this.Jihad = "YES";
        }
    }
}
