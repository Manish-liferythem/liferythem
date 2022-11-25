using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksLinkOnConfirm
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Patient patient { get; set; }
            public Error error { get; set; }
            public Resp resp { get; set; }
        }

        public class Patient
        {
            public string referenceNumber { get; set; }
            public string display { get; set; }
            public Carecontext[] careContexts { get; set; }
        }

        public class Carecontext
        {
            public string referenceNumber { get; set; }
            public string display { get; set; }
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
