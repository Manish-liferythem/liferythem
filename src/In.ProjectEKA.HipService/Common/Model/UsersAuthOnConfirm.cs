using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class UsersAuthOnConfirm
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Auth auth { get; set; }
            public Error error { get; set; }
            public Resp resp { get; set; }
        }

        public class Auth
        {
            public string accessToken { get; set; }
            public Validity validity { get; set; }
            public Patient patient { get; set; }
        }

        public class Validity
        {
            public string purpose { get; set; }
            public Requester requester { get; set; }
            public DateTime expiry { get; set; }
            public string limit { get; set; }
        }

        public class Requester
        {
            public string type { get; set; }
            public int id { get; set; }
        }

        public class Patient
        {
            public string id { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
            public int yearOfBirth { get; set; }
            public Address address { get; set; }
            public Identifier[] identifiers { get; set; }
        }

        public class Address
        {
            public string line { get; set; }
            public string district { get; set; }
            public string state { get; set; }
            public string pincode { get; set; }
        }

        public class Identifier
        {
            public string type { get; set; }
            public string value { get; set; }
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
