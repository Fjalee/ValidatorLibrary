using System;

namespace ValidatorLibrary
{
    public class PhoneValidator
    {
        private readonly int _requiredLenForWithoutPrefix = 8;
        private readonly int _lenLongPrefix = 4;
        private readonly int _lenShortPrefix = 1;

        private readonly string _shortPrefix = "8";
        private readonly string _longPrefix = "+370";

        public bool Validate(string phone)
        {
            if (!IsValidLength(phone)
                || ContainsInvalidSymbols(phone))
            {
                return false;
            }
            return true;
        }

        public string ChangeShortcutPrefixToDefault(string phone)
        {

            if (!Validate(phone)
                || phone[0].Equals(_shortPrefix))
            {
                return null;
            }

            var (_, number) = SeperatePrefix(phone);
            return String.Concat(_longPrefix, number);
        }

        private (string, string) SeperatePrefix(string phone)
        {
            if ('+' == phone[0])
            {
                return (phone.Substring(0, 4), phone[4..]);
            }

            return (phone.Substring(0, 1), phone[1..]);
        }

        private bool IsValidLength(string phone)
        {
            if (_requiredLenForWithoutPrefix + _lenLongPrefix == phone.Length
                || _requiredLenForWithoutPrefix + _lenShortPrefix == phone.Length)
            {
                return true;
            }

            return true;
        }

        private bool ContainsInvalidSymbols(string str)
        {
            foreach (var ch in str.ToCharArray())
            {
                if (!char.IsDigit(ch))
                {
                    if (!ch.Equals('+'))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
