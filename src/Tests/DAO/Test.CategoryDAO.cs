using DataAccess.Context;
using DataAccess.DAO;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using NUnit.Framework;
using System.Linq;
using Assert = NUnit.Framework.Assert;

namespace Tests.DAO
{
    [TestFixture]
    public class CategoryDAOTests
    {
        private ICategoryDAO _categoryDAO;
        private eWarehouseDbContext _dbContext;

        [SetUp]
        public void Setup()
        {
            // Create an in-memory database context for testing
            var options = new DbContextOptionsBuilder<eWarehouseDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            _dbContext = new eWarehouseDbContext(options);

            // Create an instance of the CategoryDAO with the in-memory database context
            _categoryDAO = new CategoryDAO(_dbContext);
        }

        [Test]
        public void TestCreateCategory()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Test Category",
                Description = "This is a test category"
            };

            // Act
            _categoryDAO.Create(category);

            // Assert
            var createdCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == category.Id);
            Assert.NotNull(createdCategory);
            Assert.AreEqual(category.Name, createdCategory.Name);
            Assert.AreEqual(category.Description, createdCategory.Description);
        }

        [Test]
        public void TestGetCategoryById()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Test Category",
                Description = "This is a test category"
            };
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();

            // Act
            var retrievedCategory = _categoryDAO.GetById(category.Id);

            // Assert
            Assert.NotNull(retrievedCategory);
            Assert.AreEqual(category.Name, retrievedCategory.Name);
            Assert.AreEqual(category.Description, retrievedCategory.Description);
        }

        [Test]
        public void TestGetAllCategories()
        {
            // Arrange
            var category1 = new Category()
            {
                Name = "Test Category 1",
                Description = "This is a test category"
            };
            var category2 = new Category()
            {
                Name = "Test Category 2",
                Description = "This is another test category"
            };
            _dbContext.Categories.Add(category1);
            _dbContext.Categories.Add(category2);
            _dbContext.SaveChanges();

            // Act
            var categories = _categoryDAO.GetAll();

            // Assert
            Assert.NotNull(categories);
            Assert.AreEqual(2, categories.Count);
            Assert.IsTrue(categories.Any(c => c.Name == category1.Name && c.Description == category1.Description));
            Assert.IsTrue(categories.Any(c => c.Name == category2.Name && c.Description == category2.Description));
        }

        [Test]
        public void TestUpdateCategory()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Test Category",
                Description = "This is a test category"
            };
            _categoryDAO.Create(category);

            var updatedCategory = _categoryDAO.GetById(category.Id);
            updatedCategory.Name = "Updated Category";
            updatedCategory.Description = "This is an updated category";

            // Act
            _categoryDAO.Update(updatedCategory);

            // Assert
            var retrievedCategory = _categoryDAO.GetById(category.Id);
            Assert.NotNull(retrievedCategory);
            Assert.AreEqual(updatedCategory.Name, retrievedCategory.Name);
            Assert.AreEqual(updatedCategory.Description, retrievedCategory.Description);
        }


        [Test]
        public void TestDeleteCategory()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Test Category",
                Description = "This is a test category"
            };
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();

            // Act
            _categoryDAO.Delete(category.Id);

            // Assert
            var retrievedCategory = _dbContext.Categories.FirstOrDefault(c => c.Id == category.Id);
            Assert.Null(retrievedCategory);
        }

        

        [TearDown]
        public void TearDown()
        {
            // Remove all the data from the database
            _dbContext.Categories.RemoveRange(_dbContext.Categories);
            _dbContext.SaveChanges();
        }
    }
}