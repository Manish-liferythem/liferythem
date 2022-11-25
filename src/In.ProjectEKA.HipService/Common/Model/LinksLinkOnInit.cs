using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksLinkOnInit
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public string transactionId { get; set; }
            public Link link { get; set; }
            public Error error { get; set; }
            public Resp resp { get; set; }
        }

        public class Link
        {
            public string referenceNumber { get; set; }
            public string authenticationType { get; set; }
            public Meta meta { get; set; }
        }

        public class Meta
        {
            public string communicationMedium { get; set; }
            public string communicationHint { get; set; }
            public DateTime communicationExpiry { get; set; }
        }

        public class Error
        {
            public int code { get; set; }
            public string message { get; set; }
        }

        public class Resp
        {
            public string requestId { get; set; }
        }

    }
}
