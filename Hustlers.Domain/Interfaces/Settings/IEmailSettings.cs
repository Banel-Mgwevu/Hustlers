namespace Hustlers.Domain.Interfaces.Settings
{
    public interface IEmailSettings
    {
        string Server { get; }
        int Port { get; }
        string FromEmail { get; }
        string Username { get; }
        string Password { get; }
    }
}
