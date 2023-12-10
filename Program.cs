using JoesConsoleApp.Infrastructure.Models;
using System.Threading.Channels;

//Each Category should have subcategories
//Those Subcategories should have descriptions related to them
//When a user selects a category and then a subcategory, they should be displayed the correct info

//You need to fix this

//Categories - Ticket Prices , Train Stations, Routes
//Sub Categories - TicketPrices - Fast Train, Slow Train, Medium Train - Price
//Sub Categories - Train Stations - List of train stations - Info about station
//Sub Categories - Routes - Number of Routes - Route Info - If I provide you a station Name inside of the route, and a destination station - Which train stations will I stop at.

namespace JoesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> infoList = new List<Category>()
            {
                new Category()
                {
                    Name = "1.Ticket Prices",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory() 
                        { 
                            Name = "Fast Train Ticket Prices : £50", 
                            Description = "This is a fast train which would get you to your destination in record time"
                        },
                        new Subcategory() { 
                            Name = "Medium Train Ticket Prices : £30",
                            Description = "This is a Medium train which would get you to your destination in alright time"
                        },
                        new Subcategory() { Name = "Slow Train Ticket Prices : £5",
                        Description = "This is a Slow train which would get you to your destination in alright time"
                        }

                    },
                   
                },
                new Category()
                {
                    Name = "2.Train Stations",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory() {
                            Name = "Wrexham General",
                            Description = "An old station been around since 1975"
                        },
                        new Subcategory() {
                            Name = "Clapham Junction",
                            Description = "An new station been around since 1990"
                        },
                        new Subcategory() {
                            Name = "Crewe",
                            Description = "A station that would enable you to connect to any other station"
                        }
                    },
                    
                },
                new Category()
                {
                    Name = "3.Routes",
                    Subcategories = new List<Subcategory>
                    {
                        new Subcategory() { 
                            Name = "Short Route", 
                            Description = ""},
                        new Subcategory() { 
                            Name = "Long Route",
                            Description = ""
                        },
                        new Subcategory() { 
                            Name = "Scenic Route",
                            Description = ""
                        }
                    },
                    
                },
            };

            //var example = infoList.Select(x => x.Name.First());

            //infoList.Remove(infoList.Where(x => x.Name.Equals("Ticket Prices")).First());

            // Please select from the services available
            Console.WriteLine("Please select from the services available");

            foreach (Category i in infoList)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("Please input the number of your chosen service \n");

            int userInput = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine(infoList[userInput].Name+"\n");

            foreach (Subcategory i in infoList[userInput].Subcategories)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Description+"\n");
            }
            Console.WriteLine("Which option would you like to choose");

            // Display names and insert names into dictionary for Values

            var secondResponse = Console.ReadLine();

            Console.WriteLine(secondResponse);          

            //foreach (string place in places) 
            //{
            //    Console.WriteLine( place );
            // }

            //selection = Console.ReadLine();

            //allow the user to select without if statement
            //var result = places.Where(x => x.StartsWith(selection)).First();
            //result.ToString();

        }
    }
}