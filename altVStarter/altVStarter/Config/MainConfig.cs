namespace altVStarter.Config
{
    public record MainConfig(string AltVDirectory)
    {
        public string AltVDirectory { get; } = AltVDirectory;
    }
}