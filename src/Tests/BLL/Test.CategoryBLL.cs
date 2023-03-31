using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using eWarehouse.BusinessLogic;
using Models;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests.BLL
{
    [TestFixture]

    public class CategoryBLLTests
    {
        private CategoryBLL _categoryBLL;
        private Mock<ICategoryDAO> _categoryDAOMock;

        [SetUp]
        public void SetUp()
        {
            _categoryDAOMock = new Mock<ICategoryDAO>();
            _categoryBLL = new CategoryBLL(_categoryDAOMock.Object);
        }

        [Test]
        public void TestCreateCategory()
        {
            // Arrange
            var category = new Category
            {
                Name = "Test Category",
                Description = "This is a test category"
            };

            // Act
            _categoryBLL.CreateCategory(category);

            // Assert
            _categoryDAOMock.Verify(dao => dao.Create(category), Times.Once);
        }

        [Test]
        public void TestGetCategoryById()
        {
            // Arrange
            var categoryId = 1;
            var category = new Category
            {
                Id = categoryId,
                Name = "Test Category",
                Description = "This is a test category"
            };
            _categoryDAOMock.Setup(dao => dao.GetById(categoryId)).Returns(category);

            // Act
            var result = _categoryBLL.GetCategoryById(categoryId);

            // Assert
            _categoryDAOMock.Verify(dao => dao.GetById(categoryId), Times.Once);
            Assert.AreEqual(category, result);
        }

        [Test]
        public void TestGetAllCategories()
        {
            // Arrange
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1", Description = "Description 1" },
                new Category { Id = 2, Name = "Category 2", Description = "Description 2" },
                new Category { Id = 3, Name = "Category 3", Description = "Description 3" }
            };
            _categoryDAOMock.Setup(dao => dao.GetAll()).Returns(categories);

            // Act
            var result = _categoryBLL.GetAllCategories();

            // Assert
            _categoryDAOMock.Verify(dao => dao.GetAll(), Times.Once);
            Assert.AreEqual(categories, result);
        }

        [Test]
        public void TestUpdateCategory()
        {
            // Arrange
            var category = new Category
            {
                Id = 1,
                Name = "Test Category",
                Description = "This is a test category"
            };

            // Act
            _categoryBLL.UpdateCategory(category);

            // Assert
            _categoryDAOMock.Verify(dao => dao.Update(category), Times.Once);
        }

        [Test]
        public void TestDeleteCategory()
        {
            // Arrange
            var categoryId = 1;

            // Act
            _categoryBLL.DeleteCategory(categoryId);

            // Assert
            _categoryDAOMock.Verify(dao => dao.Delete(categoryId), Times.Once);
        }
    }

}