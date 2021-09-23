namespace ValidatorLibrary
{
    public class PhoneValidator
    {
        private readonly int _requiredLenForWithoutPrefix = 8;
        private readonly int _lenLongPrefix = 4;
        private readonly int _lenShortPrefix = 1;

        public bool Validate(string phone)
        {
            if (!IsValidLength(phone)
                || !IsNumeric(phone))
            {
                return false;
            }
            return true;
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

        private bool IsNumeric(string str)
        {
            foreach (var ch in str.ToCharArray())
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
