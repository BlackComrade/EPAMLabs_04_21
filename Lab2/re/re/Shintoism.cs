using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Shintoism : Religion
    {
        public string Sacrifices { get; }
        public Shintoism(ulong number_of_followers, string holy_Bible, string key_person, string name = "Синтоизм") : base(name, number_of_followers, holy_Bible, key_person)
        {
            this.Sacrifices = "it was often presented to the gods ";
        }
    }
}
