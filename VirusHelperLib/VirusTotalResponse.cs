using System.Collections.Generic;
using System.Text.Json;

namespace VirusHelperLib
{
    public class ScanResult
    {
        public bool detected { get; set; }
        public string result { get; set; }
        public string detail { get; set; }
    }

    public class VirusTotalResponse
    {
        public string filescan_id { get; set; }
        public string permalink { get; set; }
        public int positives { get; set; }
        public string resource { get; set; }
        public int response_code { get; set; }
        public string scan_date { get; set; }
        public string scan_id { get; set; }
        public Dictionary<string, ScanResult> scans { get; set; }
        public int total { get; set; }
        public string url { get; set; }
        public string verbose_msg { get; set; }
    }

    public class VirusTotalScanner
    {
        public VirusTotalResponse DeserializeJsonResponse(string jsonResponse)
        {
            return JsonSerializer.Deserialize<VirusTotalResponse>(jsonResponse);
        }
    }
}
