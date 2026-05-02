namespace Blood_Donation_Matcher
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, string phone, string age, string gender)
        {
            Name = name;
            Phone = phone;
            Age = age;
            Gender = gender;
        }
    }
}