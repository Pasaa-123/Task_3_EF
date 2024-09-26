

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using scaffolding.Data;
using scaffolding.Models;
using System.Collections.Generic;
using System.Linq;

namespace scaffolding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            //Retrieve all categories from the production.categories table.
            //var categories = dbContext.Categories.ToList();
            //foreach (var category in categories) {
            //    Console.WriteLine($"Id : {category.CategoryId} , Name : {category.CategoryName}");
            //}


            //Retrieve the first product from the production.products table.
            //var products = dbContext.Products.FirstOrDefault();
            //if (products != null)
            //{
            //    Console.WriteLine($"ID : {products.ProductId} ," +
            //        $" Name : {products.ProductName} ," +
            //        $" Model : {products.ModelYear}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found");
            //}

            //Retrieve a specific product from the production.products table by ID.
            //var products = dbContext.Products.Find(20);
            //if (products != null)
            //{
            //    Console.WriteLine($"ID : {products.ProductId} ," +
            //        $" Name : {products.ProductName} ," +
            //        $" Model : {products.ModelYear}");
            //}
            //else
            //{
            //    Console.WriteLine("Product with this ID not found");
            //}

            //Retrieve all products from the production.products table with a certain model year.
            //short modelYear = 2016;
            //var products = dbContext.Products.Where(e => e.ModelYear == modelYear).ToList();
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"Id : {item.ProductId} ," +
            //        $" Name : {item.ProductName} ," +
            //        $" Model : {item.ModelYear}");
            //}

            //Retrieve a specific customer from the sales.customers table by ID.
            //var customers = dbContext.Customers.Find(100);
            //if (customers != null) {
            //    Console.WriteLine($"Id : {customers.CustomerId} ," +
            //        $" Name : {customers.FirstName} {customers.LastName}" +
            //        $"Email : {customers.Email}");
            //}
            //else {
            //    Console.WriteLine("Customer with this ID not found");
            //}

            //Retrieve a list of product names and their corresponding brand names.
            //var products = dbContext.Products.Include(e => e.Brand).Select(e => 
            //new {e.ProductId , e.ProductName , BrandName = e.Brand.BrandName});
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"prodID : {item.ProductId} , " +
            //        $"ProdName : {item.ProductName} , " +
            //        $"BrandName : {item.BrandName}");
            //}

            //Count the number of products in a specific category
            //var products = dbContext.Products.Where(e => e.CategoryId == 5).ToList();
            //Console.WriteLine(products.Count);

            //Calculate the total list price of all products in a specific category.
            //var products = dbContext.Products.Where(e => e.CategoryId == 4).Sum(e => e.ListPrice);
            //Console.WriteLine(products);

            //Calculate the average list price of products.
            //var products = dbContext.Products.Where(e => e.CategoryId == 4).Average(e => e.ListPrice);
            //Console.WriteLine(products);

            //Retrieve orders that are completed.
            var orders = dbContext.Orders.Where(e => e.OrderStatus == 1 
            || e.OrderStatus == 2 ||
            e.OrderStatus == 3 || 
            e.OrderStatus == 4).ToList();
            foreach (var item in orders)
            {
                Console.WriteLine($"Id : {item.OrderId} , Date : {item.OrderDate} , Status {item.OrderStatus}");
            }
        }
    }
}
