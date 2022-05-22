using Ganss.Excel;
using System;
using System.Collections.Generic;

namespace _31_Excel_Export_Nugets
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>
            {
                new Product { Name = "Nudossi", NumberInStock = 60, Price = 1.99m },
                new Product { Name = "Halloren", NumberInStock = 33, Price = 2.99m },
                new Product { Name = "Filinchen", NumberInStock = 100, Price = 0.99m },
            };

            ExcelMapper excelMapper = new ExcelMapper();
            excelMapper.Save("products.xlsx", products, "Products");
        }
    }

    public class Product
    {
        public string Name { get; set; }
        [Column("Number")]
        public int NumberInStock { get; set; }
        public decimal Price { get; set; }
    }

}
//https://github.com/mganss/ExcelMapper