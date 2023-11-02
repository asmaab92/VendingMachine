
using System.Security.Cryptography.X509Certificates;
using VendingMachine;

public class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        Console.WriteLine("------ Welcome to the Vending Machine -----");

        VendingMachineService vendingMachineService = new VendingMachineService();
        Console.WriteLine("Dear customer, here you are all the products this machine has.");
        vendingMachineService.ShowAll();

        Console.WriteLine("");
        
       
        vendingMachineService.Details(input);
        
        Console.WriteLine("");
        Console.WriteLine(" Press any key to start shopping");
        Console.ReadLine();

        vendingMachineService.InsertMoney();


        Console.WriteLine("Please choose an option.");
        vendingMachineService.Purchase();

       


            Console.WriteLine("\n----- Order Details-----");
        vendingMachineService.ShowOrder();

        Console.WriteLine("----- Your receipt-----");
        Console.WriteLine("");
        vendingMachineService.EndTransaction();

        Console.WriteLine("Please take the change.");
        Console.WriteLine("***Thank You***");
    }

}


