using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercise.main.Extension
{
    public class Users
    {
        private Dictionary<string, UserInformation> userDirectory { get; set; } = new Dictionary<string, UserInformation>();
        public Users() { }

        public bool CreateAccount(string email, string password, out string status)
        {
            status = "Validation passed";
            bool emailOK = ValidateEmail(email);
            bool passwordOK = validatePassword(password);

            
            if (!passwordOK) { status = "Invalid password"; }
            if (!emailOK) { status = "Invalid email";}
            if (!emailOK && !passwordOK) { status = "invalid email and password"; }
            
            if (emailOK && passwordOK) 
            {
                UserInformation newUser = new UserInformation(email, password);
                bool addOK = userDirectory.TryAdd(email, newUser);
                if (addOK) { return true; }
                status = "Email already exists";                
            }
            return false;
        }

        private bool validatePassword(string password) 
        {
            return password.Length >= 8;
        }

        private bool ValidateEmail(string email) 
        {
            if (string.IsNullOrWhiteSpace(email)) {  return false; }

            try 
            {
                var d = new IdnMapping();
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match) 
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e) 
            {
                return false;
            }            
            catch (ArgumentException e) 
            {
                return false;
            }

            try 
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException) 
            {
                return false;
            }
        }

        public bool EnableAccount(string email) 
        {
            if (!userDirectory.ContainsKey(email)) { return false; }
            userDirectory[email]._enabled = true;
            return true;
        }

        public bool login(string email, string password, out string response)
        {
            response = "You have logged in!";
            if (!userDirectory.ContainsKey(email)) { response = "email does not exist"; return false; }
            if (userDirectory[email]._password != password) { response = "wrong password or email"; return false; }
            if (!userDirectory[email]._enabled) { response = "your account is not activated"; return false; }
            return true; 
        }

        public UserInformation GetUser(string email)
        {
            if (userDirectory.ContainsKey(email)) 
            {
                return userDirectory[email];
            }
            throw new KeyNotFoundException();
        }
    }
}
