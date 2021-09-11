using System;

namespace ValidatorLibrary.PasswordChecker
{
    public class PasswordChecker
    {
        public int _passwordLength { get; set; }

        public PasswordChecker(int passwordLength)
        {
            _passwordLength = passwordLength;
        }

        public bool Validate(string password)
        {
            throw new NotImplementedException();
        }
    }
}
