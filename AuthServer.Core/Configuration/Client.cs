namespace AuthServer.Core.Configuration
{
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public List<String> Audiences { get; set; }
    }
}
