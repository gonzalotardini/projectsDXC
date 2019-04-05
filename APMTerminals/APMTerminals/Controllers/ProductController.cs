using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using APMTerminals.Model;
using Microsoft.AspNetCore.Mvc;

namespace APMTerminals.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        ProductModel[] products = new ProductModel[]
                {
new ProductModel { ProductId = 1, ProductName = "Tomato Soup", ProductCategory = "Groceries", ProductPrice = 1 },

new ProductModel { ProductId = 2, ProductName = "Yo-yo",     ProductCategory = "Toys", ProductPrice = 3.75M },

new ProductModel { ProductId = 3, ProductName = "Hammer",     ProductCategory = "Hardware", ProductPrice = 16.99M },

new ProductModel { ProductId = 4, ProductName = "Sugar", ProductCategory = "Groceries", ProductPrice = 10 },

new ProductModel { ProductId = 5, ProductName = "Chhota-Bheem", ProductCategory = "Toys", ProductPrice = 15 },

new ProductModel { ProductId = 6, ProductName = "Printer", ProductCategory = "Hardware", ProductPrice = 120 }
                };


        // GET: api/Products  
        [HttpGet("[action]")]
        public List<ProductModel> Obtener()
        { string path = "C:\\Users\\gtardini2\\Desktop\\files\\Prueba.txt";
                using (TextWriter tw = new StreamWriter(path))
                {
                    foreach (var item in products.ToList())
                    {
                        tw.WriteLine(string.Format("Id: {0} - Name: {1} -Category: {2} - Price: {3}", item.ProductId, item.ProductName, item.ProductCategory,item.ProductPrice));
                    }
                }
            
            return products.ToList();
        }

        [HttpGet("[action]")]
        public FileResult Download()
        {
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            string path = (@"C:\Users\gtardini2\Desktop\files\" + fileName);
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var item in products.ToList())
                {
                    tw.WriteLine(string.Format("Id: {0} - Name: {1} -Category: {2} - Price: {3}", item.ProductId, item.ProductName, item.ProductCategory, item.ProductPrice));
                }
            }
            
            byte[] fileBytes = System.IO.File.ReadAllBytes(path);
           
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }

}
