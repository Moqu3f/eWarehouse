using DataAccess.Context;
using DataAccess.DAO;
using eWarehouse.DataAccess.DAO;
using eWarehouse.DataAccess;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Assert = NUnit.Framework.Assert;

namespace Tests.DAO
{
    [TestFixture]
    public class ProductTests
    {
        private ProductDAO _productDAO;
        private CategoryDAO _categoryDAO;
        private ProviderDAO _providerDAO;
        private eWarehouseDbContext _dbContext;


        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<eWarehouseDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

             _dbContext = new eWarehouseDbContext(options);
            _productDAO = new ProductDAO(_dbContext);
            _categoryDAO = new CategoryDAO(_dbContext);
            _providerDAO = new ProviderDAO(_dbContext);
        }


        [TearDown]
        public void TearDown()
        {
            // Remove all the data from the database
            _dbContext.Products.RemoveRange(_dbContext.Products);
            _dbContext.SaveChanges();
        }

        [Test]
        public void TestCreateProduct()
        {
            // Arrange
            var category = new Category
            {
                Name = "Test Category",
                Description = "This is a test category"
            };
            _categoryDAO.Create(category);

            var provider = new Provider
            {
                Name = "Test Provider",
                Surname = "Test Surname",
                Address = "Test Address",
                Email = "test@test.com",
                Phone = "1234567890",
                Description = "This is a test provider"
            };
            _providerDAO.Create(provider);

            var product = new Product
            {
                Name = "Test Product",
                Description = "This is a test product",
                Availability = true,
                CategoryId = category.Id,
                ProviderId = provider.Id,
                Brand = "Test Brand",
                Price = 10.99m,
                Customer = "Test Customer"
            };

            // Act
            _productDAO.Create(product);

            // Assert
            var retrievedProduct = _productDAO.GetById(product.Id);
            Assert.NotNull(retrievedProduct);
            Assert.AreEqual(product.Name, retrievedProduct.Name);
            Assert.AreEqual(product.Description, retrievedProduct.Description);
            Assert.AreEqual(product.Availability, retrievedProduct.Availability);
            Assert.AreEqual(product.CategoryId, retrievedProduct.CategoryId);
            Assert.AreEqual(product.ProviderId, retrievedProduct.ProviderId);
            Assert.AreEqual(product.Brand, retrievedProduct.Brand);
            Assert.AreEqual(product.Price, retrievedProduct.Price);
            Assert.AreEqual(product.Customer, retrievedProduct.Customer);
        }

        [Test]
        public void TestGetAllProducts()
        {
            // Arrange
            var category = new Category
            {
                Name = "Test Category",
                Description = "This is a test category"
            };
            _categoryDAO.Create(category);

            var provider = new Provider
            {
                Name = "Test Provider",
                Surname = "Test Surname",
                Address = "Test Address",
                Email = "test@test.com",
                Phone = "1234567890",
                Description = "This is a test provider"
            };
            _providerDAO.Create(provider);

            var product1 = new Product
            {
                Name = "Test Product 1",
                Description = "This is a test product 1",
                Availability = true,
                CategoryId = category.Id,
                ProviderId = provider.Id,
                Brand = "Test Brand 1",
                Price = 10.99m,
                Customer = "Test Customer 1"
            };
            _productDAO.Create(product1);

            var product2 = new Product
            {
                Name = "Test Product 2",
                Description = "This is a test product 2",
                Availability = true,
                CategoryId = category.Id,
                ProviderId = provider.Id,
                Brand = "Test Brand 2",
                Price = 20.99m,
                Customer = "Test Customer 2"
            };
            _productDAO.Create(product2);

            // Act
            var products = _productDAO.GetAll();

            // Assert
            Assert.NotNull(products);
            Assert.AreEqual(2, products.Count);
        }

        [Test]
        public void TestDeleteProduct()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Product",
                Description = "This is a test product",
                Availability = true,
                CategoryId = 1,
                ProviderId = 1,
                Brand = "Test Brand",
                Price = 10.5m,
                Customer = "Test Customer"
            };
            _productDAO.Create(product);
            var productId = product.Id;

            // Act
            _productDAO.Delete(productId);

            // Assert
            var retrievedProduct = _productDAO.GetById(productId);
            Assert.IsNull(retrievedProduct);
        }

        [Test]
        public void TestGetProductById()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Product",
                Description = "This is a test product",
                Availability = true,
                CategoryId = 1,
                ProviderId = 1,
                Brand = "Test Brand",
                Price = 10.5m,
                Customer = "Test Customer"
            };
            _productDAO.Create(product);
            var productId = product.Id;

            // Act
            var retrievedProduct = _productDAO.GetById(productId);

            // Assert
            Assert.IsNotNull(retrievedProduct);
            Assert.AreEqual(productId, retrievedProduct.Id);
            Assert.AreEqual(product.Name, retrievedProduct.Name);
            Assert.AreEqual(product.Description, retrievedProduct.Description);
            Assert.AreEqual(product.Availability, retrievedProduct.Availability);
            Assert.AreEqual(product.CategoryId, retrievedProduct.CategoryId);
            Assert.AreEqual(product.ProviderId, retrievedProduct.ProviderId);
            Assert.AreEqual(product.Brand, retrievedProduct.Brand);
            Assert.AreEqual(product.Price, retrievedProduct.Price);
            Assert.AreEqual(product.Customer, retrievedProduct.Customer);
        }

        [Test]
        public void TestUpdateProduct()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Product",
                Description = "This is a test product",
                Availability = true,
                CategoryId = 1,
                ProviderId = 1,
                Brand = "Test Brand",
                Price = 10.5m,
                Customer = "Test Customer"
            };
            _productDAO.Create(product);
            var updatedProduct = _productDAO.GetById(product.Id);
            updatedProduct.Name = "Updated Product";
            updatedProduct.Description = "This is an updated product";

            // Act
            _productDAO.Update(updatedProduct);

            // Assert
            var retrievedProduct = _productDAO.GetById(product.Id);
            Assert.IsNotNull(retrievedProduct);
            Assert.AreEqual(updatedProduct.Name, retrievedProduct.Name);
            Assert.AreEqual(updatedProduct.Description, retrievedProduct.Description);
        }


    }
}
