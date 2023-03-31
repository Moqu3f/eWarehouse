using DataAccess.Context;
using DataAccess.DAO;
using DataAccess.Interfaces;
using eWarehouse.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Tests.DAO
{
    [TestFixture]
    public class ProviderDAOTests
    {
        private eWarehouseDbContext _dbContext;
        private IProviderDAO _providerDAO;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<eWarehouseDbContext>()
                .UseInMemoryDatabase(databaseName: "ProviderDatabase")
                .Options;
            _dbContext = new eWarehouseDbContext(options);
            _providerDAO = new ProviderDAO(_dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            // Remove all the data from the database
            _dbContext.Providers.RemoveRange(_dbContext.Providers);
            _dbContext.SaveChanges();
        }

        [Test]
        public void TestCreateProvider()
        {
            // Arrange
            var provider = new Provider()
            {
                Name = "Test Provider",
                Surname = "Test Surname",
                Address = "Test Address",
                Email = "testprovider@test.com",
                Phone = "123456789",
                Description = "This is a test provider"
            };

            // Act
            _providerDAO.Create(provider);

            // Assert
            var retrievedProvider = _dbContext.Providers.FirstOrDefault(p => p.Id == provider.Id);
            Assert.NotNull(retrievedProvider);
            Assert.AreEqual(provider.Name, retrievedProvider.Name);
            Assert.AreEqual(provider.Surname, retrievedProvider.Surname);
            Assert.AreEqual(provider.Address, retrievedProvider.Address);
            Assert.AreEqual(provider.Email, retrievedProvider.Email);
            Assert.AreEqual(provider.Phone, retrievedProvider.Phone);
            Assert.AreEqual(provider.Description, retrievedProvider.Description);
        }


        [Test]
        public void TestDeleteProvider()
        {
            // Arrange
            var provider = new Provider()
            {
                Name = "Test Provider",
                Surname = "Test Surname",
                Address = "Test Address",
                Email = "testprovider@test.com",
                Phone = "123456789",
                Description = "This is a test provider"
            };
            _dbContext.Providers.Add(provider);
            _dbContext.SaveChanges();

            // Act
            _providerDAO.Delete(provider.Id);

            // Assert
            var retrievedProvider = _dbContext.Providers.FirstOrDefault(p => p.Id == provider.Id);
            Assert.Null(retrievedProvider);
        }

        [Test]
        public void TestGetAllProviders()
        {
            // Arrange
            var provider1 = new Provider()
            {
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-1234",
                Description = "Test Provider 1"
            };
            _providerDAO.Create(provider1);

            var provider2 = new Provider()
            {
                Name = "Jane",
                Surname = "Smith",
                Address = "456 Main St",
                Email = "jane.smith@example.com",
                Phone = "555-5678",
                Description = "Test Provider 2"
            };
            _providerDAO.Create(provider2);

            // Act
            var providers = _providerDAO.GetAll();

            // Assert
            Assert.AreEqual(2, providers.Count);
            Assert.IsTrue(providers.Any(p =>
                p.Id == provider1.Id && p.Name == provider1.Name && p.Surname == provider1.Surname));
            Assert.IsTrue(providers.Any(p =>
                p.Id == provider2.Id && p.Name == provider2.Name && p.Surname == provider2.Surname));
        }

        [Test]
        public void TestGetProviderById()
        {
            // Arrange
            var provider = new Provider()
            {
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-1234",
                Description = "Test Provider"
            };
            _providerDAO.Create(provider);

            // Act
            var retrievedProvider = _providerDAO.GetById(provider.Id);

            // Assert
            Assert.NotNull(retrievedProvider);
            Assert.AreEqual(provider.Name, retrievedProvider.Name);
            Assert.AreEqual(provider.Surname, retrievedProvider.Surname);
            Assert.AreEqual(provider.Address, retrievedProvider.Address);
            Assert.AreEqual(provider.Email, retrievedProvider.Email);
            Assert.AreEqual(provider.Phone, retrievedProvider.Phone);
            Assert.AreEqual(provider.Description, retrievedProvider.Description);
        }

        [Test]
        public void TestUpdateProvider()
        {
            // Arrange
            var provider = new Provider()
            {
                Name = "Test Provider",
                Surname = "Test Surname",
                Address = "Test Address",
                Email = "test@test.com",
                Phone = "1234567890",
                Description = "This is a test provider"
            };
            _providerDAO.Create(provider);

            var updatedProvider = _providerDAO.GetById(provider.Id);
            updatedProvider.Name = "Updated Provider";
            updatedProvider.Surname = "Updated Surname";
            updatedProvider.Address = "Updated Address";
            updatedProvider.Email = "updated@test.com";
            updatedProvider.Phone = "0987654321";
            updatedProvider.Description = "This is an updated provider";

            // Act
            _providerDAO.Update(updatedProvider);

            // Assert
            var retrievedProvider = _providerDAO.GetById(provider.Id);
            Assert.NotNull(retrievedProvider);
            Assert.AreEqual(updatedProvider.Name, retrievedProvider.Name);
            Assert.AreEqual(updatedProvider.Surname, retrievedProvider.Surname);
            Assert.AreEqual(updatedProvider.Address, retrievedProvider.Address);
            Assert.AreEqual(updatedProvider.Email, retrievedProvider.Email);
            Assert.AreEqual(updatedProvider.Phone, retrievedProvider.Phone);
            Assert.AreEqual(updatedProvider.Description, retrievedProvider.Description);
        }

    }
}
