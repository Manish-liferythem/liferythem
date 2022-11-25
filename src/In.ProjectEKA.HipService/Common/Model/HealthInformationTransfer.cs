using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class HealthInformationTransfer
    {
        public class Rootobject
        {
            public int pageNumber { get; set; }
            public int pageCount { get; set; }
            public string transactionId { get; set; }
            public Entry[] entries { get; set; }
            public Keymaterial keyMaterial { get; set; }
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

        public class Entry
        {
            public string content { get; set; }
            public string media { get; set; }
            public string checksum { get; set; }
            public string careContextReference { get; set; }
            public string link { get; set; }
        }

    }
}
