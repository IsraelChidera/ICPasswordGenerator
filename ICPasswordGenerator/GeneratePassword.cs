using System.Security.Cryptography;

namespace ICPasswordGenerator
{
    public class GeneratePassword
    {     
        private string? _passwordLength;        

        private string? GetPasswordLength {
            get { return _passwordLength; }            
            set { _passwordLength = value; }
        }

        public void GenerateRandomCharacters()
        {
            Console.WriteLine("Enter your desired password length");
            GetPasswordLength = Console.ReadLine();

            int passwordLength;
            while (!int.TryParse(GetPasswordLength, out passwordLength))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!\nPlease enter a valid number");
                Console.ResetColor();

                Console.WriteLine("Enter your desired password length");
                GetPasswordLength = Console.ReadLine();                
            }

            Console.WriteLine($"Password l: {passwordLength}");

            char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=".ToCharArray();
            char[] password = new char[passwordLength];
            using (RandomNumberGenerator randomGenerator = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[passwordLength];

                randomGenerator.GetBytes(randomBytes);

                for (int i = 0; i < passwordLength; i++)
                {
                    int randomIndex = randomBytes[i] % characters.Length;
                    password[i] = characters[randomIndex];
                }

            }
            Console.WriteLine($"Here is your password: {new string(password)}");            

        }

        public void DisplayGenerate()
        {
            GenerateRandomCharacters();
        }
    }
}













