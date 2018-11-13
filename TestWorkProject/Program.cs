using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>() {new PhoneNumber(1), new PhoneNumber(2), new PhoneNumber(3)};
            PhoneDirectory directory = new PhoneDirectory(phoneNumbers);
            PhoneNumber phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
            phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
            phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
            phoneNumber = directory.Get();
            if (phoneNumber == null)
            {
                Console.WriteLine("No Available Numbers");
            }
            else
            {
                Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            }
            Console.WriteLine(directory.Check(1));
            Console.WriteLine(directory.Check(2));
            Console.WriteLine(directory.Check(3));
            Console.WriteLine(directory.Check(4));


            directory.Release(1);
            directory.Release(2);
            directory.Release(3);
            directory.Release(4);

            phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
            phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
            phoneNumber = directory.Get();
            Console.WriteLine($"{phoneNumber.Number} was selected, it's status is {phoneNumber.Status}");
            phoneNumber.Status = PhoneNumberStatus.Unavailable;
        }
    }
}
