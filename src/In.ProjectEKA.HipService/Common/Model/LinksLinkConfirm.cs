using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class LinksLinkConfirm
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Confirmation confirmation { get; set; }
        }

        public class Confirmation
        {
            public string linkRefNumber { get; set; }
            public string token { get; set; }
        }

    }
}
