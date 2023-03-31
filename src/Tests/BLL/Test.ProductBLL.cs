using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using BusinessLogic.BLL;
using DataAccess.Interfaces;
using Models;
using Assert = NUnit.Framework.Assert;

[TestFixture]
public class ProductBLLTests
{
    private Mock<IProductDAO> _mockProductDAO;
    private ProductBLL _productBLL;

    [SetUp]
    public void Setup()
    {
        _mockProductDAO = new Mock<IProductDAO>();
        _productBLL = new ProductBLL(_mockProductDAO.Object);
    }

    [Test]
    public void CreateProduct_ValidProduct_ProductCreatedSuccessfully()
    {
        // Arrange
        var product = new Product { Name = "Product A", Price = 10.0m };
        _mockProductDAO.Setup(x => x.Create(product));

        // Act
        _productBLL.CreateProduct(product);

        // Assert
        _mockProductDAO.Verify(x => x.Create(product), Times.Once);
    }

    [Test]
    public void GetProductById_ValidId_ProductReturnedSuccessfully()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Product A", Price = 10.0m };
        _mockProductDAO.Setup(x => x.GetById(product.Id)).Returns(product);

        // Act
        var result = _productBLL.GetProductById(product.Id);

        // Assert
        Assert.AreEqual(product, result);
    }

    [Test]
    public void GetAllProducts_ProductsExist_ReturnsListOfProducts()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.0m },
            new Product { Id = 2, Name = "Product B", Price = 20.0m },
            new Product { Id = 3, Name = "Product C", Price = 30.0m }
        };
        _mockProductDAO.Setup(x => x.GetAll()).Returns(products);

        // Act
        var result = _productBLL.GetAllProducts();

        // Assert
        Assert.AreEqual(products, result);
    }

    [Test]
    public void UpdateProduct_ValidProduct_ProductUpdatedSuccessfully()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Product A", Price = 10.0m };
        _mockProductDAO.Setup(x => x.Update(product));

        // Act
        _productBLL.UpdateProduct(product);

        // Assert
        _mockProductDAO.Verify(x => x.Update(product), Times.Once);
    }

    [Test]
    public void DeleteProduct_ValidId_ProductDeletedSuccessfully()
    {
        // Arrange
        var productId = 1;
        _mockProductDAO.Setup(x => x.Delete(productId));

        // Act
        _productBLL.DeleteProduct(productId);

        // Assert
        _mockProductDAO.Verify(x => x.Delete(productId), Times.Once);
    }

    [Test]
    public void GetProductsSortedByName_ShouldReturnSortedListByName()
    {
        // Arrange
        var productList = new List<Product>()
            {
                new Product() { Name = "Banana", Brand = "Brand1", Price = 2.5m },
                new Product() { Name = "Apple", Brand = "Brand2", Price = 3.0m },
                new Product() { Name = "Orange", Brand = "Brand3", Price = 2.0m }
            };
        _mockProductDAO.Setup(x => x.GetAll()).Returns(productList);

        // Act
        var result = _productBLL.GetProductsSortedByName();

        // Assert
        Assert.AreEqual(productList[1], result[0]);
        Assert.AreEqual(productList[0], result[1]);
        Assert.AreEqual(productList[2], result[2]);
    }

    [Test]
    public void GetProductsSortedByBrand_ShouldReturnSortedListByBrand()
    {
        // Arrange
        var productList = new List<Product>()
            {
                new Product() { Name = "Banana", Brand = "Brand1", Price = 2.5m },
                new Product() { Name = "Apple", Brand = "Brand2", Price = 3.0m },
                new Product() { Name = "Orange", Brand = "Brand3", Price = 2.0m }
            };
        _mockProductDAO.Setup(x => x.GetAll()).Returns(productList);

        // Act
        var result = _productBLL.GetProductsSortedByBrand();

        // Assert
        Assert.AreEqual(productList[0], result[0]);
        Assert.AreEqual(productList[1], result[1]);
        Assert.AreEqual(productList[2], result[2]);
    }

    [Test]
    public void GetProductsSortedByPrice_ShouldReturnSortedListByPrice()
    {
        // Arrange
        var productList = new List<Product>()
            {
                new Product() { Name = "Banana", Brand = "Brand1", Price = 2.5m },
                new Product() { Name = "Apple", Brand = "Brand2", Price = 3.0m },
                new Product() { Name = "Orange", Brand = "Brand3", Price = 2.0m }
            };
        _mockProductDAO.Setup(x => x.GetAll()).Returns(productList);

        // Act
        var result = _productBLL.GetProductsSortedByPrice();

        // Assert
        Assert.AreEqual(productList[2], result[0]);
        Assert.AreEqual(productList[0], result[1]);
        Assert.AreEqual(productList[1], result[2]);
    }


}
