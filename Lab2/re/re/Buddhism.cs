using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Buddhism : Religion
    {
        public string Nirvana { get; }
        public Buddhism(ulong number_of_followers, string holy_Bible, string key_person, string name = "Буддизм") : base(name, number_of_followers, holy_Bible, key_person)
        {
            this.Nirvana = "Сносим к чертям душу";
        }
    }
}
