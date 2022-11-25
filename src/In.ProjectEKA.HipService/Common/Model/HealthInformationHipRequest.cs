using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class HealthInformationHipRequest
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public string transactionId { get; set; }
            public Hirequest hiRequest { get; set; }
        }

        public class Hirequest
        {
            public Consent consent { get; set; }
            public Daterange dateRange { get; set; }
            public string dataPushUrl { get; set; }
            public Keymaterial keyMaterial { get; set; }
        }

        public class Consent
        {
            public string id { get; set; }
        }

        public class Daterange
        {
            public DateTime from { get; set; }
            public DateTime to { get; set; }
        }

        public class Keymaterial
        {
            public string cryptoAlg { get; set; }
            public string curve { get; set; }
            public Dhpublickey dhPublicKey { get; set; }
            public string nonce { get; set; }
        }

        public class Dhpublickey
        {
            public DateTime expiry { get; set; }
            public string parameters { get; set; }
            public string keyValue { get; set; }
        }

    }
}
