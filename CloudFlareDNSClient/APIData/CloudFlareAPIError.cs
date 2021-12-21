namespace CloudFlareDNSClient
{
    public class CloudFlareAPIError
    {
        public bool success
        {
            get;
            set;
        }

        public APIError[] errors
        {
            get;
            set;
        }

        public object[] messages
        {
            get;
            set;
        }

        public object result
        {
            get;
            set;
        }
    }

    public class APIError
    {
        public int code
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }
    }
}