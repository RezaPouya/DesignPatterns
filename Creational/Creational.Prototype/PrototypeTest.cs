using System;
using System.Linq;
using Xunit;

namespace Creational.Prototype
{
    public class PrototypeTest
    {

        Person person = new Person
        {
            Fname = "Reza",
            Lname = "Pouya",
            Expriences = new System.Collections.Generic.List<Job>
            {
                new Job{ Order = 1 , Company = "Dadeh Kavi Behbahan" , Role = "FullStack Developer"},
                new Job{ Order = 2 , Company = "Shabakeh Gostar Sanam Behbahan" , Role = "FullStack Developer"},
                new Job{ Order = 3 , Company = "Navoshgaran Asr-e- Parseh Tehran" , Role = "Backend Developer"},
            }
        };

        [Fact]
        public void Test_Shallow_Copy()
        {
            // Arrange 
            var person = this.person;

            // Act 
            var shallowCopy = (Person) this.person.ShallowClone() ;
            shallowCopy.Expriences.FirstOrDefault().Order = 0;
            // Assert 
            Assert.Same(person.Expriences, shallowCopy.Expriences);
            Assert.Equal(person.Expriences.FirstOrDefault().Order, shallowCopy.Expriences.FirstOrDefault().Order);
        }

        [Fact]
        public void Test_Deep_Copy()
        {
            // Arrange 
            var person = this.person;

            // Act 
            var deepCopy = (Person)this.person.Clone();
            deepCopy.Expriences.FirstOrDefault().Order = 0;
            // Assert 
            Assert.NotSame(person.Expriences, deepCopy.Expriences);
            Assert.NotEqual(person.Expriences.FirstOrDefault().Order, deepCopy.Expriences.FirstOrDefault().Order);
        }

    }
}
