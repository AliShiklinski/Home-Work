namespace Task_1_05._26._2024
{
    internal class User
    {
        
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (IsValidPassword(value))
                {
                    password = value;
                    Console.WriteLine("Password is valid.");
                }
                else
                {
                    Console.WriteLine("Password is invalid.");
                }
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length <= 7)
                return false;

            bool hasUpper = false, hasLower = false, hasSpecial = false, hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasNumber = true;
                else if (char.IsPunctuation(c) || char.IsSymbol(c)) hasSpecial = true;
            }

            return hasUpper && hasLower && hasSpecial && hasNumber;
        }
    }
}

