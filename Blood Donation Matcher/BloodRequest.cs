using System;

namespace Blood_Donation_Matcher
{
    public class BloodRequest : Person
    {
        public string BloodType { get; set; }
        public string RequiredBags { get; set; }
        public string Status { get; set; }
        public string RequestDate { get; set; }

        public BloodRequest(string name, string phone, string age, string gender,
                            string type, string bags, string status, string date)
            : base(name, phone,int.Parse(age),gender,(Person.BloodType)Enum.Parse(typeof(Person.BloodType),type),status ,"AnyValue")
        {
            BloodType = type;
            RequiredBags = bags;
            Status = status;
            RequestDate = date;
        }

        public string GetFullMessage()
        {
            return $@"Request Registered Successfully:
            Patient: {Name}
            Blood Type: {BloodType}
            Age: {Age}
            Gender: {Gender}
            Phone: {Phone}
            Required Units: {RequiredBags}
            Status: {Status}
            Date: {RequestDate}";
        }
    }
}