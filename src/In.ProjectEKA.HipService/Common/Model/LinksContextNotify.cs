using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksContextNotify
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Notification notification { get; set; }
        }

        public class Notification
        {
            public Patient patient { get; set; }
            public Carecontext careContext { get; set; }
            public string[] hiTypes { get; set; }
            public DateTime date { get; set; }
            public Hip hip { get; set; }
        }

        public class Patient
        {
            public string id { get; set; }
        }

        public class Carecontext
        {
            public string patientReference { get; set; }
            public string careContextReference { get; set; }
        }

        public class Hip
        {
            public int id { get; set; }
        }

    }
}
