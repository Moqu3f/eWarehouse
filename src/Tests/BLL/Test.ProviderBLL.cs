using System;
using System.Collections.Generic;
using BusinessLogic.BLL;
using DataAccess.Interfaces;
using Models;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace BusinessLogic.Tests
{
    [TestFixture]
    public class ProviderBLLTests
    {
        private ProviderBLL _providerBLL;
        private Mock<IProviderDAO> _providerDAOMock;

        [SetUp]
        public void Setup()
        {
            _providerDAOMock = new Mock<IProviderDAO>();
            _providerBLL = new ProviderBLL(_providerDAOMock.Object);
        }

        [Test]
        public void CreateProvider_ValidProvider_CallsProviderDAOCreate()
        {
            // Arrange
            var provider = new Provider
            {
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-555-5555",
                Description = "Provider description"
            };

            // Act
            _providerBLL.CreateProvider(provider);

            // Assert
            _providerDAOMock.Verify(dao => dao.Create(It.IsAny<Provider>()), Times.Once);
        }

        [Test]
        public void GetProviderById_ValidId_ReturnsProvider()
        {
            // Arrange
            var provider = new Provider
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-555-5555",
                Description = "Provider description"
            };
            _providerDAOMock.Setup(dao => dao.GetById(provider.Id)).Returns(provider);

            // Act
            var result = _providerBLL.GetProviderById(provider.Id);

            // Assert
            Assert.AreEqual(provider, result);
        }

        [Test]
        public void GetAllProviders_ReturnsListOfProviders()
        {
            // Arrange
            var provider1 = new Provider
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-555-5555",
                Description = "Provider description"
            };
            var provider2 = new Provider
            {
                Id = 2,
                Name = "Jane",
                Surname = "Doe",
                Address = "456 Oak Ave",
                Email = "jane.doe@example.com",
                Phone = "555-555-5555",
                Description = "Provider description"
            };
            var providers = new List<Provider> { provider1, provider2 };
            _providerDAOMock.Setup(dao => dao.GetAll()).Returns(providers);

            // Act
            var result = _providerBLL.GetAllProviders();

            // Assert
            CollectionAssert.AreEqual(providers, result);
        }

        [Test]
        public void UpdateProvider_ValidProvider_CallsProviderDAOUpdate()
        {
            // Arrange
            var provider = new Provider
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Address = "123 Main St",
                Email = "john.doe@example.com",
                Phone = "555-555-5555",
                Description = "Provider description"
            };

            // Act
            _providerBLL.UpdateProvider(provider);

            // Assert
            _providerDAOMock.Verify(dao => dao.Update(It.IsAny<Provider>()), Times.Once);
        }
    }

}