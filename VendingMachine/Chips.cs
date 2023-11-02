using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Chips : Product
    {
        public string Flavour { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }

        public Chips(int id, string name, int price, string flavour) : base(id, name, price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Flavour = flavour;
        }

        public override String Examine()
        {
            return $"Chips ID: {Id}, Chips: {Name}, Cost: {Price} SEK, Flavour: {Flavour} ";

        }

        public override string Use()
        {
            return $"Eat your chips.";
        }

    }

}
