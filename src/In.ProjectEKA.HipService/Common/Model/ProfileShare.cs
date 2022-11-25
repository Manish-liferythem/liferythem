using System;

namespace In.ProjectEKA.HipService.Common.Model
{
    public class ProfileShare
    {
        public class Rootobject
        {
            public string requestId { get; set; }
            public DateTime timestamp { get; set; }
            public Intent intent { get; set; }
            public Location location { get; set; }
            public Profile profile { get; set; }
        }

        public class Intent
        {
            public string type { get; set; }
        }

        public class Location
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        public class Profile
        {
            public string hipCode { get; set; }
            public Patient patient { get; set; }
        }

        public class Patient
        {
            public string healthId { get; set; }
            public string healthIdNumber { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
            public Address address { get; set; }
            public int yearOfBirth { get; set; }
            public int dayOfBirth { get; set; }
            public int monthOfBirth { get; set; }
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

    }
}
