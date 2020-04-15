using System;

namespace OnlineParser.Api.Models
{
    public class NowInStock
    {
        public string Vendor { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime LastStock { get; set; }
    }
}
