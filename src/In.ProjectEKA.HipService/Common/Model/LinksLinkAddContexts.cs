using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksLinkAddContexts
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Link link { get; set; }
        }

        public class Link
        {
            public string accessToken { get; set; }
            public Patient patient { get; set; }
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

    }
}
