using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class HealthInformationNotify
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Notification notification { get; set; }
        }

        public class Notification
        {
            public string consentId { get; set; }
            public string transactionId { get; set; }
            public DateTime doneAt { get; set; }
            public Notifier notifier { get; set; }
            public Statusnotification statusNotification { get; set; }
        }

        public class Notifier
        {
            public string type { get; set; }
            public string id { get; set; }
        }

        public class Statusnotification
        {
            public string sessionStatus { get; set; }
            public string hipId { get; set; }
            public Statusrespons[] statusResponses { get; set; }
        }

        public class Statusrespons
        {
            public string careContextReference { get; set; }
            public string hiStatus { get; set; }
            public string description { get; set; }
        }

    }
}
