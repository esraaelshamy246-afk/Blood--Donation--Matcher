using System;

namespace Blood_Donation_Matcher
{
    public class BloodRequest : Person
    {
        // قمنا بحذف BloodType من هنا لأنه موجود بالفعل في Person حسب التحذير
        public string RequiredBags { get; set; }
        public string Status { get; set; }
        public string RequestDate { get; set; }

        public BloodRequest(string name, string phone, string age, string gender,
                            string type, string bags, string status, string date)
             : base(name, phone, age, gender)
        {
            // BloodType سيتم توريثه من Person فلا داعي لتعريفه مجدداً هنا
            this.BloodType = type;
            RequiredBags = bags;
            Status = status;
            RequestDate = date;
        }

        public string GetFullMessage()
        {
            // ملاحظة: تأكدي أن اسم الخاصية في كلاس Person هو Gender وليس اسماً آخر
            return $@"Request Registered Successfully:
            Patient: {Name}
            Blood Type: {BloodType}
            Age: {Age}
            Gender: {base.Gender} 
            Phone: {Phone}
            Required Units: {RequiredBags}
            Status: {Status}
            Date: {RequestDate}";
        }
    }
}