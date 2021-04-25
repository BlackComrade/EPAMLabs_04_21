using System;
using System.Collections.Generic;
using System.Text;

namespace Abstr
{
    class Fascism : Polit
    {
        public string Measures_of_influence { get; set; }
        public Fascism (string ruler, string elections, int degree_of_public_support): base (ruler, elections, degree_of_public_support)
        {
            if (degree_of_public_support < 80)
            {
                this.Measures_of_influence = "Необходимы любые методы, вплоть до репрессий. Мы тут власть!";
            }    
            else
            {
                this.Measures_of_influence = "А как же иначе? Этот плепс понимает свое место. А ту горстку несогласных мы раздавим!";
            }
        }
        public override string TheySay()
        {
            return "Скованные одной цепью...";
        }
    }
}
