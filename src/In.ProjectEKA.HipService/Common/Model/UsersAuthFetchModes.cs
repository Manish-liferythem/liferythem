using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class UsersAuthFetchModes
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Query query { get; set; }
        }

        public class Query
        {
            public string id { get; set; }
            public string purpose { get; set; }
            public Requester requester { get; set; }
        }

        public class Requester
        {
            public string type { get; set; }
            public string id { get; set; }
        }

    }
}
