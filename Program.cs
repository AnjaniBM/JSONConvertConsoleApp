using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONConvertConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.getProduct();
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);
            
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(json);
            string name = deserializedProduct.Name;
            Console.WriteLine("Deserialized Product\t=" + name);



        }       



        class Product {
        
            public string Name { get; set; }
            public DateTime Expiry
            {
                get; set;
            }
            public string[] Sizes { get; set; }

            public Product() { }
            public void getProduct()
            {
               
                Name = "Apple";
                Expiry = new DateTime(2008, 12, 28);
                Sizes = new string[] { "Small" };
            }

        }
    }
}
