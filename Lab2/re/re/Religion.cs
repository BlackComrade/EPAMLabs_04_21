using System;
using System.Collections.Generic;
using System.Text;

namespace re
{
    class Religion
    {
        public string Name { get; set; }
        public ulong Number_of_followers { get; set; }
        public string Holy_Bible { get; set; }
        public string Key_person { get; set; }
        public string World_religion { get; set; }

        public Religion(string name, ulong number_of_followers, string holy_Bible, string key_person)
        {
            this.Name = name;
            this.Number_of_followers = number_of_followers;
            this.Holy_Bible = holy_Bible;
            this.Key_person = key_person;
            if (Number_of_followers < 100000000)
            {
                this.World_religion = "NO";
            }
            else
            {
                this.World_religion = "YES";
            }
        }
    }

}

