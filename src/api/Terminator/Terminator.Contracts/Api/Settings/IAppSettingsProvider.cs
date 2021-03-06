namespace Terminator.Contracts.Api.Settings
{
    public interface IAppSettingsProvider
    {
        public IAppSettings AppSettings { get; set; }
    }
}
