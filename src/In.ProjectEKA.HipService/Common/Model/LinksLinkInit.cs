using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksLinkInit
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
            public string referenceNumber { get; set; }
            public Carecontext[] careContexts { get; set; }
        }

        public class Carecontext
        {
            public string referenceNumber { get; set; }
        }

    }
}
