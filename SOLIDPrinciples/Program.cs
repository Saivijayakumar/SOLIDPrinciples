using SOLIDPrinciples.Dependency_Inversion_Principle__DIP_;
using SOLIDPrinciples.Interface_Segregation_Principle__ISP_;
using SOLIDPrinciples.LiskovSubstitutionPrinciple__LSP_;
using SOLIDPrinciples.Open_Closed_Principle__OCP_;
using SOLIDPrinciples.SingleResponsibilityPrinciple__SRP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to SOLID Desigin Principle");
            Console.WriteLine("\n1.Single Responsibility Principle(SRP)\n2.Open Close Principle(OCP)\n3.Liskov Substitution Principle (LSP)\n4.Interface Segregation Principle (ISP)\n5.Dependency Inversion Principle (DIP)");
            Console.Write("\nAt which Desigin Principle you want to work on :");
            switch(Console.ReadLine())
            {
                case "1":
                    IGarage garageGate = new GarageGate();
                    Garage garage = new Garage(garageGate);
                    garage.OpenForService();
                    garage.DoServiec();
                    garage.closeGarage();
                    break;
                case "2":
                    RegularSavingAccount regular = new RegularSavingAccount();
                    Console.WriteLine($"\nInterest For Regular Saving Account is :{regular.CalculateInterest(883944.55)}");
                    SalarySavingAccount saving = new SalarySavingAccount();
                    Console.WriteLine($"\nInterest For Salary Saving Account is :{saving.CalculateInterest(44838.99)}");
                    break;
                case "3":
                    Shape rectangle = new Rectangle(5,3);
                    Console.WriteLine($"Area for rectangle is :{rectangle.Area()}"); 
                    break;
                case "4":
                    Console.WriteLine("\nMessage for online pay Orders ");
                    OnlineOrder online = new OnlineOrder();
                    online.PlaceOrder();
                    online.OnlinePayment();
                    Console.WriteLine("\nMessage for offline pay Orders ");
                    OfflineOrder offline = new OfflineOrder();
                    offline.PlaceOrder();
                    break;
                case "5":
                    IAutomobile automobile = new Jeep();
                    //IAutomobile automobile = new SUV();
                    AutomobileController automobileController = new AutomobileController(automobile);
                    automobile.Ignition();
                    automobile.Stop();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice.....");
                   break;
            }
            Console.ReadLine();
        }
    }
}
