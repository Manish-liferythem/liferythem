using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class UsersAuthConfirm
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public string transactionId { get; set; }
            public Credential credential { get; set; }
        }

        public class Credential
        {
            public string authCode { get; set; }
            public Demographic demographic { get; set; }
        }

        public class Demographic
        {
            public string name { get; set; }
            public string gender { get; set; }
            public string dateOfBirth { get; set; }
            public Identifier identifier { get; set; }
        }

        public class Identifier
        {
            public string type { get; set; }
            public string value { get; set; }
        }

    }
}
