using System;

namespace re
{
    class Program
    {
        static void Main(string[] args)
        {
            Christianity christianity = new Christianity(2292454000, "Есть", "Иисус Христос");
            Console.WriteLine("Особенность религии: " + christianity.Сoming_of_jesus +  " . " + " Name: " + christianity.Name + " Number of followers: " + christianity.Number_of_followers + " Holy Bible: " + christianity.Holy_Bible + " Key person: " + christianity.Key_person + " World religion: " + christianity.World_religion);
           
            Islam islam = new Islam(1549444000, "Есть", "Аллах");
            Console.WriteLine("Особенность религии: " + islam.Jihad + " . " + " Name: " + islam.Name + " Number of followers: " + islam.Number_of_followers + " Holy Bible: " + islam.Holy_Bible + " Key person: " + islam.Key_person + " World religion: " + islam.World_religion);

            Judaism judaism = new Judaism(14641000, "Есть", "Иисус Христос");
            Console.WriteLine("Особенность религии: " + judaism.Holiday_every_week + " . " + " Name: " + judaism.Name + " Number of followers: " + judaism.Number_of_followers + " Holy Bible: " + judaism.Holy_Bible + " Key person: " + judaism.Key_person + " World religion: " + judaism.World_religion);


            Buddhism buddhism = new Buddhism(468736000, "Нет", "Будда");
            Console.WriteLine("Особенность религии: " + buddhism.Nirvana + " . " + " Name: " + buddhism.Name + " Number of followers: " + buddhism.Number_of_followers + " Holy Bible: " + buddhism.Holy_Bible + " Key person: " + buddhism.Key_person + " World religion: " + buddhism.World_religion);

            Shintoism shintoism = new Shintoism(2782000, "Нет", "Аматерасу");
            Console.WriteLine("Особенность религии: " + shintoism.Sacrifices + " . " + " Name: " + shintoism.Name + " Number of followers: " + shintoism.Number_of_followers + " Holy Bible: " + shintoism.Holy_Bible + " Key person: " + shintoism.Key_person + " World religion: " + shintoism.World_religion);
            
            Console.ReadLine();
        }
    }
}
