using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oblig_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig_1.Tests
{
    [TestClass()]
    public class FamilyAppTests
    {
        [TestMethod()]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Born: 2000 Died: 3000 Father: Per (Id=23) Mother: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [TestMethod()]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [TestMethod()]
        public void OppgaveThreeTestingRandomFields()
        {
            var p = new Person
            {
                FirstName = "Jamie",
                BirthYear = 1000,
                DeathYear = 2000,
                Mother = new Person() { Id = 105, FirstName = "Ole Jhonny" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Jamie  Born: 1000 Died: 2000 Mother: Ole Jhonny (Id=105)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}
