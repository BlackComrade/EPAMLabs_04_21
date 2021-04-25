using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Judaism : Religion
    {
        public string Holiday_every_week { get;}
        public Judaism(ulong number_of_followers, string holy_Bible, string key_person, string name = "Иудаизм") : base(name, number_of_followers, holy_Bible, key_person)
        {
            this.Holiday_every_week = "Шаббат";
        }
    }
}
