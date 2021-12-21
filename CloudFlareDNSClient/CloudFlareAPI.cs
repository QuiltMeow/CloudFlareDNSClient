using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace CloudFlareDNSClient
{
    public class CloudflareAPI // HTTP 客戶端 : Thread Safe
    {
        private const int ZONE_FETCH_LIMIT = 50;
        private const int DNS_FETCH_LIMIT = 100;

        private const string END_POINT = "https://api.cloudflare.com/client/v4";
        private readonly Setting setting;

        public HttpClient client
        {
            get;
            private set;
        }

        public CloudflareAPI(HttpClient client, Setting setting)
        {
            this.client = client;
            this.setting = setting;
        }

        public IList<string> listZoneId()
        {
            HttpRequestMessage request = getRequestMessage(HttpMethod.Get, $"{END_POINT}/zones?status=active&page=1&per_page={ZONE_FETCH_LIMIT}&order=name&direction=asc&match=all");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.SendAsync(request).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            validateCloudFlareResult(response, result, "取得 Zone Id 列表");
            return JsonConvert.DeserializeObject<ListZoneResponse>(result).result.Select(data => data.id).ToList();
        }

        public DNSRecordResponse listDNSRecord(IPProtocol protocol, string zoneId)
        {
            string recordType = protocol == IPProtocol.IPv4 ? "A" : "AAAA";
            HttpRequestMessage request = getRequestMessage(HttpMethod.Get, $"{END_POINT}/zones/{zoneId}/dns_records?type={recordType}&page=1&per_page={DNS_FETCH_LIMIT}&order=name&direction=asc&match=all");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.SendAsync(request).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            validateCloudFlareResult(response, result, "取得 DNS 記錄列表");
            return JsonConvert.DeserializeObject<DNSRecordResponse>(result);
        }

        private void validateCloudFlareResult(HttpResponseMessage response, string result, string action)
        {
            if (!response.IsSuccessStatusCode)
            {
                switch (setting.apiAccessMethod)
                {
                    case APIAccessMethod.API_TOKEN:
                        {
                            throw new Exception($"無法處理動作 [{action}] 請檢查 API 權杖設定與權限 (讀取 / 編輯) 是否正確");
                        }
                    case APIAccessMethod.API_KEY:
                        {
                            CloudFlareAPIError cloudFlareError = JsonConvert.DeserializeObject<CloudFlareAPIError>(result);
                            throw new Exception(cloudFlareError.errors?.FirstOrDefault().message);
                        }
                }
            }
        }

        public DNSUpdateResponse updateDNS(IPProtocol protocol, string zoneId, string dnsRecordId, string dnsRecordName, string content, bool proxy)
        {
            string recordType = protocol == IPProtocol.IPv4 ? "A" : "AAAA";
            DNSUpdateRequest dnsUpdateRequest = new DNSUpdateRequest()
            {
                content = content,
                name = dnsRecordName,
                proxied = proxy,
                type = recordType
            };

            HttpRequestMessage request = getRequestMessage(HttpMethod.Put, $"{END_POINT}/zones/{zoneId}/dns_records/{dnsRecordId}");
            request.Content = new StringContent(JsonConvert.SerializeObject(dnsUpdateRequest), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.SendAsync(request).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            validateCloudFlareResult(response, result, $"更新 {protocol} DNS 紀錄");
            return JsonConvert.DeserializeObject<DNSUpdateResponse>(result);
        }

        public IList<DNSResult> getAllDNSRecordByZone(bool queryIPv4 = true, bool queryIPv6 = true)
        {
            if (!queryIPv4 && !queryIPv6)
            {
                throw new Exception("請指定查詢內容");
            }

            IList<string> zoneIdList = Regex.Replace(setting.zoneId, @"\s+", string.Empty).Split(new char[] {
                ','
            }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!zoneIdList.Any())
            {
                zoneIdList = listZoneId();
            }

            List<DNSResult> allDNSEntry = new List<DNSResult>();
            foreach (string zoneId in zoneIdList)
            {
                if (queryIPv4)
                {
                    DNSRecordResponse dnsRecord = listDNSRecord(IPProtocol.IPv4, zoneId);
                    allDNSEntry.AddRange(dnsRecord.result);
                }

                if (queryIPv6)
                {
                    DNSRecordResponse dnsRecord = listDNSRecord(IPProtocol.IPv6, zoneId);
                    allDNSEntry.AddRange(dnsRecord.result);
                }
            }
            return allDNSEntry.Distinct().ToList();
        }

        private HttpRequestMessage getRequestMessage(HttpMethod httpMethod, string requestUri)
        {
            HttpRequestMessage ret = new HttpRequestMessage(httpMethod, requestUri);
            ret.Headers.ConnectionClose = true;

            switch (setting.apiAccessMethod)
            {
                case APIAccessMethod.API_TOKEN:
                    {
                        ret.Headers.Add("Authorization", $"Bearer {setting.apiAccess}");
                        break;
                    }
                case APIAccessMethod.API_KEY:
                    {
                        ret.Headers.Add("X-Auth-Key", setting.apiAccess);
                        ret.Headers.Add("X-Auth-Email", setting.mail);
                        break;
                    }
            }
            return ret;
        }
    }
}