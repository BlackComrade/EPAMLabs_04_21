using System;

namespace Abstr
{
    class Program
    {
        static void Main(string[] args)
        {
            Monarchy monarchy = new Monarchy("Один человек", "Выборов нет", 50);
            Console.WriteLine("МОНАРХИЯ - " + " Кто правит в таком строе: " + monarchy.Ruler + ". Хоть какие нибудь выборы есть куда нибудь? :" + monarchy.Elections + ". Какая поддержка у населения данного строя?: " + monarchy.Degree_of_public_support + ". Количество монархий в мире = " + monarchy.Number_in_the_world);
            Fascism fascism = new Fascism("Один человек", "Выборов нет", 40);
            Console.WriteLine("ФАШИЗМ - " + "Кто правит в таком строе: " + fascism.Ruler + ". Хоть какие нибудь выборы есть куда нибудь? :" + fascism.Elections + ". Какая поддержка у населения данного строя?: " + fascism.Degree_of_public_support + ". Итак, что нибудь будем делать из за поддержки?: " + fascism.Measures_of_influence );
            Console.WriteLine( $"Что говорим мы поем при монархии : {monarchy.TheySay()}");
            Console.WriteLine($"Что говорим мы поем при фашизме : {fascism.TheySay()}");
            Console.ReadLine();
        }
    }
}
