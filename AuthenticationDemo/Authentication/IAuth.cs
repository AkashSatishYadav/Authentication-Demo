namespace AuthenticationDemo.Authentication
{
    public interface IAuth
    {
        string? Authentication(string username, string password);
    }
}
