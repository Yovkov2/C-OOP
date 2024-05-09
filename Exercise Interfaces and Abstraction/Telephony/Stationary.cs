using System.Linq;
using System;

namespace Telephony

{
    public class Stationary : ICall
    {
        public string Calling(string phoneNumber)
        {
            if (!IsValidateCall(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {phoneNumber}";
        }

        private bool IsValidateCall(string phoneNumber) => phoneNumber.All(char.IsDigit);
    }
}