namespace DesignPatterns.Structural.Facade
{
    public class UserAuthenticator
    {
        public bool Authenticate(int userId, string password)
        {
            Console.WriteLine("Authenticating user...");

            return userId == 1234 && password == "password";
        }
    }
}
