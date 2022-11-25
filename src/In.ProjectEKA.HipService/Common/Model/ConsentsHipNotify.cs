using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class ConsentsHipNotify
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Notification notification { get; set; }
        }

        public class Notification
        {
            public string status { get; set; }
            public string consentId { get; set; }
            public Consentdetail consentDetail { get; set; }
            public string signature { get; set; }
            public bool grantAcknowledgement { get; set; }
        }

        public class Consentdetail
        {
            public string schemaVersion { get; set; }
            public string consentId { get; set; }
            public DateTime createdAt { get; set; }
            public Patient patient { get; set; }
            public Carecontext[] careContexts { get; set; }
            public Purpose purpose { get; set; }
            public Hip hip { get; set; }
            public Consentmanager consentManager { get; set; }
            public string[] hiTypes { get; set; }
            public Permission permission { get; set; }
        }

        public class Patient
        {
            public string id { get; set; }
        }

        public class Purpose
        {
            public string text { get; set; }
            public string code { get; set; }
            public string refUri { get; set; }
        }

        public class Hip
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Consentmanager
        {
            public string id { get; set; }
        }

        public class Permission
        {
            public string accessMode { get; set; }
            public Daterange dateRange { get; set; }
            public DateTime dataEraseAt { get; set; }
            public Frequency frequency { get; set; }
        }

        public class Daterange
        {
            public DateTime from { get; set; }
            public DateTime to { get; set; }
        }

        public class Frequency
        {
            public string unit { get; set; }
            public int value { get; set; }
            public int repeats { get; set; }
        }

        public class Carecontext
        {
            public string patientReference { get; set; }
            public string careContextReference { get; set; }
        }

    }
}
