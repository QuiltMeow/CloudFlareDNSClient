using System;

namespace CloudFlareDNSClient
{
    public class DNSRecordResponse
    {
        public bool success
        {
            get;
            set;
        }

        public object[] errors
        {
            get;
            set;
        }

        public object[] messages
        {
            get;
            set;
        }

        public DNSResult[] result
        {
            get;
            set;
        }

        public ResultInformation result_info
        {
            get;
            set;
        }
    }

    public class DNSResult
    {
        public string id
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string content
        {
            get;
            set;
        }

        public bool proxiable
        {
            get;
            set;
        }

        public bool proxied
        {
            get;
            set;
        }

        public int ttl
        {
            get;
            set;
        }

        public bool locked
        {
            get;
            set;
        }

        public string zone_id
        {
            get;
            set;
        }

        public string zone_name
        {
            get;
            set;
        }

        public DateTime created_on
        {
            get;
            set;
        }

        public DateTime modified_on
        {
            get;
            set;
        }

        public Data data
        {
            get;
            set;
        }
    }

    public class Data
    {
    }

    public class DNSUpdateResponse
    {
        public bool success
        {
            get;
            set;
        }

        public object[] errors
        {
            get;
            set;
        }

        public object[] messages
        {
            get;
            set;
        }

        public DNSResult result
        {
            get;
            set;
        }
    }

    public class DNSUpdateRequest
    {
        public string type
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string content
        {
            get;
            set;
        }

        public bool proxied
        {
            get;
            set;
        }
    }
}