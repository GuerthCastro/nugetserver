namespace NuGetServer.Entities.Config;

public class NuGetIndex
{
    public string ServiceName { get; set; } = "Private NuGet Server";
    public string ServiceUrl { get; set; } = "http://localhost:5071/nuget";
}
