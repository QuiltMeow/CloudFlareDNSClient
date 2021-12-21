namespace CloudFlareDNSClient
{
    public enum IPProtocol
    {
        IPv4,
        IPv6
    }

    public enum APIAccessMethod
    {
        API_KEY,
        API_TOKEN
    }

    public enum IPDetectMethod
    {
        LOCAL,
        REMOTE
    }

    public enum ResultIcon
    {
        SUCCESS,
        FAIL,
        LOADING
    }
}