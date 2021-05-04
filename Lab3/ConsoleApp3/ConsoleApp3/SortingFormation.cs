using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SortingFormation : IComparable<SortingFormation>
    {
        public string Name { get; set; }
        public int Number_of_followers { get; set; }

        public int CompareTo(SortingFormation compareReligion)
        {
            if (compareReligion == null)
                return 1;
            else
                return this.Number_of_followers.CompareTo(compareReligion.Number_of_followers);
        }
        public bool Equals(SortingFormation other)
        {
            if (other == null) return false;
            return (this.Number_of_followers.Equals(other.Number_of_followers));
        }
    }
}
