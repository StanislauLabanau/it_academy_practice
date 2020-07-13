using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture._14.Task3
{
    class Neighbor
    {
        public string FullName { get; private set; }
        public string FlatNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public Neighbor (string fullName, string flatNumber, string phoneNumber)
        {
            FullName = fullName;
            FlatNumber = flatNumber;
            PhoneNumber = phoneNumber;
        }

        public void ShowNumber(string flatNumber)
        {
            if (FlatNumber.Equals(flatNumber))
                Console.WriteLine(PhoneNumber);
        }
    }
}
