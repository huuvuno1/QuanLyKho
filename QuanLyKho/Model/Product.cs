using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    internal class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; }
        public float Price { get; set; }
        public float Quantity { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, float price, float quantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}
