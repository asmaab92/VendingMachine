using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drink : Product
    {
        public int DrinkVolume { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }


        public Drink(int id, string name, int price, int drinkVolume) : base(id, name, price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.DrinkVolume = drinkVolume;
        }
        
        public override String Examine()
        {
            return   $"Drink ID: {Id}, Drink: {Name}, Cost: {Price} SEK, Volume: {DrinkVolume} ml";

        }

        public override string Use()
        {
            return $"Drink the beverage: {Name}";
        }
    }
}
