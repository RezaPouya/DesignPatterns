using System;

namespace Creational.Builder
{
    public class Person
    {
        public Person(string nationalId, 
            string fname,
            string lname, 
            string fatherName, 
            string motherName, 
            DateTimeOffset birthDate,
            GenderType gender)
        {
            NationalId = nationalId;
            Fname = fname;
            Lname = lname;
            FatherName = fatherName;
            MotherName = motherName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public string NationalId { get; private set; }
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string FatherName { get; private set; }
        public string MotherName { get; private set; }
        public DateTimeOffset BirthDate { get; private set; }
        public GenderType Gender { get; private set; }
    }
}