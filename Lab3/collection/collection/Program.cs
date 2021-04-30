using System;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        public static string Value_input()
        {
            Console.WriteLine("Введите название религии");
            Console.Write("-> ");
            string name_of_relegion = Console.ReadLine();
            return name_of_relegion;
        }

        static void Main(string[] args)
        {
            List<Religion> religion = new List<Religion>();
            religion.Add(new Religion() { Name = "Христианство", Number_of_followers = 2293 });
            religion.Add(new Religion() { Name = "Ислам", Number_of_followers = 1550 });
            religion.Add(new Religion() { Name = "Иудаизм", Number_of_followers = 15 });
            religion.Add(new Religion() { Name = "Синтоизм", Number_of_followers = 3 });
            religion.Add(new Religion() { Name = "Буддизм", Number_of_followers = 470 });

            string name = Value_input();
            try
            {
                bool religionChek = false;
                for (int i = 0; i < religion.Count; i++)
                {
                    if (name == religion[i].Name)
                    {
                        religionChek = true;
                        Console.WriteLine("Количество последователей (млн.чел.): " + religion[i].Number_of_followers);
                    }
                }
                if (religionChek == false) 
                throw new ReligionExeption("Нет такой религии в списке.");
            }
            catch (ReligionExeption ex) 
            {
                Console.WriteLine("Это другое " + ex.Message);
            }
        }
    }
}
