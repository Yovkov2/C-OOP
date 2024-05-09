namespace Telephony

{
    using System;
    using System.Linq;

    public class Smartphone : ICall, IBrowse
    {
        public string Browse(string browser)
        {
            if(!IsValidateBrowse(browser))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing... {browser}";
        }

        public string Calling(string phoneNumber)
        {
            if (!IsValidateCall(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }

        private bool IsValidateCall(string phoneNumber) => phoneNumber.All(char.IsDigit);
        private bool IsValidateBrowse(string browser) => !browser.All(char.IsDigit);
    }
}