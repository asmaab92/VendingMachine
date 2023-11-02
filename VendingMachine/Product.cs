using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Product
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public Product (int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        
        public abstract  string Examine();
        public abstract string Use();

        

    }
}
