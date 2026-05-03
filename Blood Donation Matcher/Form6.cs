public class Person
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Age { get; set; } // جعلناه string ليتوافق مع استخدامك في BloodRequest
    public string Gender { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string BloodType { get; set; } // تم تغييره لـ string لتسهيل التعامل مع الـ ComboBox

    // المشد (Constructor) الذي تستخدمه فئة BloodRequest
    public Person(string name, string phone, string age, string gender)
    {
        Name = name;
        Phone = phone;
        Age = age;
        Gender = gender;
    }

    // المشد الخاص بعملية التسجيل الكاملة
    public Person(string name, string phone, string age, string address, string bloodType, string city)
    {
        Name = name;
        Phone = phone;
        Age = age;
        Address = address;
        BloodType = bloodType;
        City = city;
    }
}

