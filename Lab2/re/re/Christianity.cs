using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Christianity : Religion
    {
        public string Сoming_of_jesus { get; }
        public Christianity(ulong number_of_followers, string holy_Bible, string key_person, string name = "Христианство") : base(name, number_of_followers, holy_Bible, key_person)
        {
            this.Сoming_of_jesus = "Начало летоисчесления";
        }
    }
}

