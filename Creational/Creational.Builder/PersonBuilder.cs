using System;

namespace Creational.Builder
{
    public class PersonBuilder
    {
        private string _nationalId = "";
        private string _fName = "";
        private string _lName = "";
        private string _fatherName = "";
        private string _motherName = "";
        private DateTimeOffset _birthDate = DateTimeOffset.UtcNow;
        private GenderType _gender = GenderType.NotSpecified;

        public PersonBuilder(string nationalId, string fName, string lName)
        {
            _nationalId = nationalId;
            _fName = fName;
            _lName = lName;
        }

        public Person Build()
        {
            return new Person(_nationalId,
                _fName,
                _lName,
                _fatherName,
                _motherName,
                _birthDate,
                _gender);
        }

        public PersonBuilder WithFatherName(string name)
        {
            _fatherName = name;
            return this;
        }

        public PersonBuilder WithMotherName(string name)
        {
            _motherName = name;
            return this;
        }

        public PersonBuilder WithBirthDate(DateTimeOffset birthDate)
        {
            _birthDate = birthDate;
            return this;
        }

        public PersonBuilder WithGender(GenderType gender)
        {
            _gender = gender;
            return this;
        }
    }
}