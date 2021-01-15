using System;
using Xunit;

namespace Creational.Builder
{
    public class BuilderDesignPatternTest
    {
        [Fact]
        public void Should_Pass_If_Can_Create_Films()
        {
            Person person = new PersonBuilder("9988776655", "Reza", "Pouya")
                .WithGender(GenderType.Male)
                .WithFatherName("Ali")
                .Build();

            Assert.Equal("Ali", person.FatherName);
        }
    }
}
