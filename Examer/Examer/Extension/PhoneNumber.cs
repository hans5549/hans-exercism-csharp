using System.Text.RegularExpressions;

namespace Examer.Extension
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) ||
                !Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
            }

            // An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
            string firstThreeDigits = phoneNumber.Substring(0, 3);
            bool isNewYork = firstThreeDigits.Contains("212");

            // An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7
            string lastThreeDigits = phoneNumber.Substring(4, 3);
            bool isFake = lastThreeDigits == "555";

            // The last 4 digits of the number.
            string localNumber = phoneNumber.Substring(phoneNumber.Length - 4, 4);

            return (isNewYork, isFake, localNumber);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
           (bool _, bool IsFake, string _) = phoneNumberInfo;
           return IsFake;
        }
    }
}
