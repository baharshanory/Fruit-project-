using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit

{
    internal class Program
    {
        class fruit
        {
            public string nameFruit { get; set; }
            public float weight { get; set; }
            public string color { get; set; }
            public float price { get; set; }

            public int quan { get; set; }



            public fruit(string nameFruit, float weight, string color, float price, int quan)
            {
                this.nameFruit = nameFruit;
                this.weight = weight;
                this.color = color;
                this.price = price;
                this.quan = quan;
            }

           

            public void receive()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Color: ");
                string color = Console.ReadLine();

                Console.Write("Weight (in kg): ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Price (in $): ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("quantoty: ");
                int quan = int.Parse(Console.ReadLine());
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"name:{nameFruit},weight:{weight},color:{color},price:{price},quantity{quan}");


            }

        }
        class Buyer
        {


            public List<fruit> ShoppingList { get; private set; }

            public Buyer()
            {
                ShoppingList = new List<fruit>();
            }

            public void BuyFruit(fruit fruit, double quantity)
            {
                if (fruit != null)
                {
                    ShoppingList.Add(new fruit(fruit.nameFruit,fruit.weight, fruit.color,fruit.price,fruit.quan));
                    Console.WriteLine($"{quantity}kg of {fruit.nameFruit} added to your shopping list.");
                }
                else
                {
                    Console.WriteLine("Fruit not found.");
                }
            }

            public void ShowShoppingList()
            {
                double totalCost = 0;
                Console.WriteLine("Your Shopping List:");
                foreach (var item in ShoppingList)
                {
                    double cost = item.price * item.weight;
                    totalCost += cost;
                    Console.WriteLine($"{item.weight}kg of {item.nameFruit}: {cost} currency units");
                }
                Console.WriteLine($"Total Cost: {totalCost} currency units");
            }
        }



        class seller
        {
            private List<fruit> fruits = new List<fruit>();
            public void Addfruit(fruit fruit)

            {
                fruits.Add(fruit);
                Console.WriteLine($"{fruit.nameFruit} adedd to the list");
            }

            public void removefruit(fruit fruit)

            {
                fruits.Remove(fruit);
                Console.WriteLine($"{fruit.nameFruit} removed to the list");
            }
            public void upfruit(string namefruit, int qaun)
            {

                var fruit = fruits.Find(f => f.nameFruit.Equals(namefruit, StringComparison.Ordinal));
                if (fruit != null)
                {
                    fruit.quan += fruit.quan;
                    Console.WriteLine($"your request has been made:");
                }
                else
                {
                    Console.WriteLine("No fruit with this name was found:");


                }



            }

            public void Display()
            {
                foreach (var fruit in fruits)
                {
                    fruit.DisplayInfo();
                }
            }
        }
    
        static void Main(string[] args)
        {
            fruit fruits = new fruit("apple", 2, "green", 34,9);
            seller seller = new seller();
            Buyer buyer = new Buyer();
            Console.WriteLine("Please enter your code if you are a seller and press one if you are a buyer:");
            string cod = Console.ReadLine();
              if(cod=="831005")

            {
                
               
                Console.WriteLine("If you want to put fruit in your store, enter the number 1:");
                Console.WriteLine("If you want to add, enter number 2:");
                Console.WriteLine("If you want to del, enter number 3:");
                Console.WriteLine("Enter the number 4 to display the fruit inventory:");

                int numeroffruits = int.Parse(Console.ReadLine());
                if (numeroffruits== 1)
                {
                    fruits.receive();
                }
                else
                {
                    Console.Write("(: : ");
                }
                if (numeroffruits == 2)
                {
                    seller.Addfruit(new fruit("appl", 5, "red", 55, 5));
                    seller.upfruit("appl", 5);

                }

                else
                {
                    Console.Write("(: : ");
                }

                    if(numeroffruits==3)
                {
                    seller.removefruit(new fruit("appl", 5, "red", 55, 5));
                }

                else
                {
                    Console.Write("(: : ");
                }
                
                
                if(numeroffruits==4)
                {
                    seller.Display();
                }
               
                else
                {
                    Console.WriteLine("error:");
                }
                  
                 

               
                    
                    //fekkkkkkkkkr
                
            }
            else
            {
                Console.Write("(: : ");
            }
               if(cod=="1")
            {

                Console.WriteLine("If you want to add, enter number 1:");
                Console.WriteLine("If you want to del, enter number 2:");
                Console.WriteLine("Enter the number 3to display the fruit inventory:");
                int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Color: ");
                    string color = Console.ReadLine();

                    Console.Write("quantoty: ");
                    int quan = int.Parse(Console.ReadLine());

                    buyer.ShowShoppingList();
                }
                else
                {
                    Console.Write("(: : ");
                }
                if (number == 2)
                {
                    seller.removefruit(new fruit("apll", 2, "green", 5000, 10));

                }
                else
                {
                    Console.Write("(: : ");
                }
                 if (number == 3)
                {
                    Console.WriteLine("\n all show fruit:");
                    seller.Display();
                }
                else
                {
                    Console.Write("(: : ");
                }
                


                
                buyer.BuyFruit(new fruit("appl", 5, "red", 55, 5),5);


                Console.WriteLine("\nfruit after buyers:");
                seller.Display();
            }
              else
            {
                Console.WriteLine("pleas try again:");
            }

        }
    }
}
