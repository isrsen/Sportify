namespace Terminator.Contracts.Api.Settings
{
    public interface IAppSettings
    {
        public string JwtSecret { get; set; }
    }
}
