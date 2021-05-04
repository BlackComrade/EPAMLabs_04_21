using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class ListOfReligion
    {
        static void Main(string[] args)
        {
            List<SortingFormation> religion = new List<SortingFormation>();
            religion.Add(new SortingFormation() { Name = "Христианство", Number_of_followers = 2293 });
            religion.Add(new SortingFormation() { Name = "Ислам", Number_of_followers = 1550 });
            religion.Add(new SortingFormation() { Name = "Иудаизм", Number_of_followers = 15 });
            religion.Add(new SortingFormation() { Name = "Синтоизм", Number_of_followers = 3 });
            religion.Add(new SortingFormation() { Name = "Буддизм", Number_of_followers = 470});
            
            religion.Sort();
            foreach (SortingFormation p in religion)
            {
               Console.WriteLine("Название религии: " + p.Name + ". Количество последователей (млн.чел.): " + p.Number_of_followers);
            }
        }
    }
}
