using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkProject
{
    enum PhoneNumberStatus
    {
        Nonexisitant = 0,
        Available = 1,
        Unavailable = 2
    }
    class PhoneDirectory
    {

        List<PhoneNumber> PhoneNumbers;

        public PhoneDirectory(List<PhoneNumber> phoneNumbers)
        {
            PhoneNumbers = phoneNumbers;
        }


        public PhoneNumber Get()
        {
            //Get the first available number
            try
            {
                PhoneNumber availableNumber = PhoneNumbers.Where(x => x.Status == PhoneNumberStatus.Available).First();
                return availableNumber;
            }
            catch (InvalidOperationException)
            {
                //There were no available numbers to get
                return null;
                throw new InvalidOperationException($"There were no available numbers in the Phone Directory.");
            }

        }
        public PhoneNumberStatus Check(int number)
        {
            try
            {
                PhoneNumber numberToCheck = PhoneNumbers.Where(x => x.Number == number).First();
                return numberToCheck.Status;
            }
            catch (InvalidOperationException)
            {
                //that number didn't exist
                return PhoneNumberStatus.Nonexisitant;
                throw new InvalidOperationException($"{number} did not exist in the Phone Directory.");
            }
        }
        public Boolean Release(int number)
        {
            try
            {
                PhoneNumber numberToCheck = PhoneNumbers.Where(x => x.Number == number).First();
                numberToCheck.Release();
                if (numberToCheck.Status != PhoneNumberStatus.Available) { return false; }
                return true;
            }
            catch (InvalidOperationException)
            {
                //that number didn't exist
                return false;
                throw new InvalidOperationException($"{number} did not exist in the Phone Directory.");
            }




        }
    }
    class PhoneNumber
    {

        public PhoneNumberStatus Status { get; set; }
        public int Number { get; set; }

        public PhoneNumber(int number)
        {
            Number = number;
            Status = PhoneNumberStatus.Available;
        }

        public void Release()
        {
            //First check if the number is not available
            if (Status == PhoneNumberStatus.Unavailable)
            {
                Status = PhoneNumberStatus.Available;
            }
        }



    }
}
