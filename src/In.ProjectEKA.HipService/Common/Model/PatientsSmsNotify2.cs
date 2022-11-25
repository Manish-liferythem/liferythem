using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class PatientsSmsNotify2
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Notification notification { get; set; }
        }

        public class Notification
        {
            public string phoneNo { get; set; }
            public Hip hip { get; set; }
        }

        public class Hip
        {
            public string name { get; set; }
            public string id { get; set; }
        }

    }
}
