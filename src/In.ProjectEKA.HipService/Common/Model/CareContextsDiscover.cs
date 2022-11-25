using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class CareContextsDiscover
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public string transactionId { get; set; }
            public Patient patient { get; set; }
        }

        public class Patient
        {
            public string id { get; set; }
            public Verifiedidentifier[] verifiedIdentifiers { get; set; }
            public Unverifiedidentifier[] unverifiedIdentifiers { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
            public int yearOfBirth { get; set; }
        }

        public class Verifiedidentifier
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class Unverifiedidentifier
        {
            public string type { get; set; }
            public string value { get; set; }
        }

    }
}
