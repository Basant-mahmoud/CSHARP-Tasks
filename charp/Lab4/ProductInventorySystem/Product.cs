using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventorySystem
{
    class Product
    { 
            int Id          {get;set;}
            string Name     {get;set;}
            Category Category{get;set;}
           public double Price    {get;set;}
           Size ProductSize { get; set; }
        public Product(int _id, string _name,Category _category,double _price,Size _size)
        {
            Id = _id;
            Name = _name;
            Category = _category;
            Price = _price;
            ProductSize = _size;

        }
        public void display()
        {
            Console.WriteLine($"Product Name is {Name} and id is {Id} and Categoey is {Category} and product price is {Price} Product Size  Depth={ProductSize.Depth} Width={ProductSize.Width} Height={ProductSize.Height} ");
        }
    }
}
