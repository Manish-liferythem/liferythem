using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class HealthInformationHipOnRequest
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Hirequest hiRequest { get; set; }
            public Error error { get; set; }
            public Resp resp { get; set; }
        }

        public class Hirequest
        {
            public string transactionId { get; set; }
            public string sessionStatus { get; set; }
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
