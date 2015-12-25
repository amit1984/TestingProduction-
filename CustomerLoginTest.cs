using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Production.Controllers;
using Production.enums;
using Production.ViewModels.customer;
using Production.Models;
using Production.Interface;
using Production.services;
using Moq;
using UnitTestProduction.Lib;
using Production.fitnesse;
using System.Data;

namespace UnitTestProduction
{
    
    [TestClass]
    public class CustomerLoginTest
    {
       
        [TestMethod]
        public void createCustomer()
        {

            var context = new TestToDoDbContext();
            IcountryRepository countryRepository;
            UnitofWork unitOfWork = new UnitofWork();
            try
            {
                var coun = new country();
                coun.countryName = "ausiopa";
                //context.country.Add(coun);
                //context.SaveChanges();
                unitOfWork.CountryRepository.Insert(coun);
                unitOfWork.Save();
              
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
