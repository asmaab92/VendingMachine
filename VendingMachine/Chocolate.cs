using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Chocolate : Product
    {
        public int Weight { get; set; }
        public override int Id { get ; set ; }
        public override string Name { get ; set; }
        public override int Price { get ; set; }

        public Chocolate(int id, string name, int price, int weight) : base(id, name, price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public override String Examine()
        {
            return $"Chocolate ID: {Id}, Chocolate: {Name}, Cost: {Price} SEK, Weight: {Weight} gr";

        }

        public override string Use()
        {
            return $"Eat your chocolate.";
        }
    }
}
