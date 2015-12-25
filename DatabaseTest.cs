using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Production.Interface;
using Production.services;
using Production.fitnesse;
using System.Data;

namespace UnitTestProduction
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void DatabaseMigrationTest()
        {
            Database c = new Database();
            Assert.AreEqual(c.DatabaseMigrationUpdate(), true); 
        }
    }
}
