namespace ValidatorLibrary
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {
            var atSymbolIndex = email.LastIndexOf('@');
            var dotSymbolIndex = email.LastIndexOf('.');
            if (-1 == atSymbolIndex || -1 == dotSymbolIndex)
            {
                return false;
            }

            var username = email.Substring(0, atSymbolIndex);
            var domain = email.Substring(atSymbolIndex + 1, dotSymbolIndex - atSymbolIndex - 1);
            var tld = email[(dotSymbolIndex + 1)..];

            return true;
        }
    }
}
