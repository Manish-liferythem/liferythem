using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class PatientsProfileOnShare
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Acknowledgement acknowledgement { get; set; }
            public Error error { get; set; }
            public Resp resp { get; set; }
        }

        public class Acknowledgement
        {
            public string status { get; set; }
            public string healthId { get; set; }
            public string tokenNumber { get; set; }
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
