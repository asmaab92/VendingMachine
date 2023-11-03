using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachineService : IVending
    {
        private int moneyPool = 0;
        private List<Product> products = new List<Product>();
        int change = 0;
        int cost = 0;
        int amount;
        int addedMoney;

        readonly int[] ValidMoneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public  Product  Purchase()
        {
            int addProduct;
            do
            {
                Console.WriteLine("Enter '1' for Drink. \nEnter '2' for chocolate. \nEnter '3' for chips.");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Drink drink = new Drink(choice, "Water", 15, 250);
                    products.Add(drink);
                    Console.WriteLine(drink.Examine());

                }
                else if (choice == 2)
                {
                    Chocolate chocolate = new Chocolate(choice, "Bounty", 10, 150);
                    products.Add(chocolate);
                    Console.WriteLine(chocolate.Examine());

                }
                else if (choice == 3)
                {
                    Chips chips = new Chips(3, "Pringles", 45, "Cheese");
                    products.Add(chips);
                    Console.WriteLine(chips.Examine());
                }
                Console.WriteLine("Enter 1 if you want to buy more products. Enter 0 if you want to check out.\n");
                addProduct = Convert.ToInt32(Console.ReadLine());
            }

            while (addProduct == 1);
            return null;
        }

       public  List<string> ShowAll() 
       {           
             List<string> productInfo = new List<string>();

                productInfo.Add("1.Water");
                productInfo.Add("2.Bounty");
                productInfo.Add("3.Pringles");
            foreach (string product1 in productInfo)
            {
                Console.WriteLine(product1);
            }
            return productInfo;
        }

         public  string Details(int Id)
          {
            Product product = products.Find(p => p.Id == Id);

            Console.WriteLine("To show the details of a product enter its ID.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Drink drink = new Drink(input, "Water", 15, 250);
                Console.WriteLine(drink.Examine());
            }
            else if (input == 2)
            {
                Chocolate chocolate = new Chocolate(input, "Bounty", 10, 150);
                Console.WriteLine(chocolate.Examine());
            }
            else if (input == 3)
            {
                Chips chips = new Chips(3, "Pringles", 45, "Cheese");
                Console.WriteLine(chips.Examine());
            }
            
            return product?.Examine();
          }

         public void InsertMoney()
         {            
                Console.WriteLine($"The machine accepts only the followin denomination: \n" + "1, 5, 10, 20, 50, 100, 500, 1000");
            do
            {
                Console.WriteLine("Please insert money");
                 amount = Convert.ToInt32(Console.ReadLine());

                if (Array.Exists(ValidMoneyDenominations, d => d == amount))
                {
                    moneyPool += amount;
                }
                else
                {
                    Console.WriteLine("Invalid money denomination.");
                }
                Console.WriteLine("Press 1 to add more money. Press 0 to choose your favourite. \n");
                addedMoney = Convert.ToInt32(Console.ReadLine());
            }
            while (addedMoney == 1);
            moneyPool += addedMoney;
            Console.WriteLine($"The total amount is: {moneyPool} SEK \n" );
         }

         public List<string> ShowOrder()
         {
            if (moneyPool >= cost)
            { List<string> orderInfo = new List<string>();
                Console.WriteLine("\n Your order is as following: ");

                foreach (Product product in products)
                {
                    orderInfo.Add($"{product.Id} - {product.Name} - {product.Price}SEK");
                    Console.WriteLine($"Product ID: {product.Id}, Product Name: {product.Name}, Price: {product.Price} SEK");
                    Console.WriteLine(product.Use());
                    cost += product.Price;

                }

                Console.WriteLine($"The total price of the products is: {cost} SEK");
            }
             else
            {
                throw new Exception("Insufficient funds");

            }
            return null;
           
         }
             
         public Dictionary<int, int> EndTransaction()
         {      
          change = moneyPool - cost;
          Console.WriteLine($"The total amount you inserted is: {moneyPool}, The change is: {change}");
          return new Dictionary<int, int>();

         }   
        public int GetTotalAmount()
        {
            return moneyPool;
        }
    }
}
