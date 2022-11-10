using XAPI.NET.Abstractions;

namespace XAPI.NET.Statements.Statements;
public class Statement : IStatement<Guid>
{
    public Guid Id { get; init; }

    public Statement()
    {
        Id = Guid.NewGuid();
        TimeStamp = DateTime.Now.ToString("u");
    }

    public Actor Actor { get; set; }
    public Verb Verb { get; set; }
    public Context Context { get; set; }
    public IList<Extenstion> Extenstions { get; set; } = new List<Extenstion>();
    public string TimeStamp { get; set; }

    public void AddPlatformInformation(Dictionary<string, string> platforNames)
    {
        const string PLATFORM = "https://nelc.gov.sa/extensions/platform";
        Extenstions.Add(new Extenstion(PLATFORM, platforNames));
    }
    public IList<Extenstion> AddAttemptedExtension(int sttempteNumber)
    {
        const string ATTEMPT_ID = "http://id.tincanapi.com/extension/attempt-id";
        Extenstions.Add(new Extenstion(ATTEMPT_ID, sttempteNumber));
        return Extenstions;
    }
    public void AddBrowserInfoExtension()
    {
        const string BROWSER_INFO_ID = "http://id.tincanapi.com/extension/browser-info";
        Extenstions.Add(new Extenstion(BROWSER_INFO_ID, new BrowserInfo()));
    }
    public void AddJwsCertificateLocation()
    {
        const string JWS_CERTIFICATE_LOCATION_ID = "http://id.tincanapi.com/extension/jws-certificate-location";
        Extenstions.Add(new Extenstion(JWS_CERTIFICATE_LOCATION_ID, new CertificateLocation()));
    }
}
