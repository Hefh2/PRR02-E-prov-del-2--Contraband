using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov__Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user how many cars they want to create and saves the answer in a string.
            Console.WriteLine("How many cars do you want to check? 1 - 5");
            string answer = Console.ReadLine();

            //If the answer is not 1, 2, 3, 4 or 5 the user will be stuck in a loop until they answer according to instructions.
            while (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5")
            {
                Console.Clear();
                Console.WriteLine("Please give and answer, 1 - 5.");
                answer = Console.ReadLine();
            }

            //Puts the answered number in an in called carAmount.
            int carAmount = 0;
            if (answer != "1")
            {
                carAmount = 1;
            } else if (answer != "2")
            {
                carAmount = 2;
            } else if (answer != "3")
            {
                carAmount = 3;
            } else if (answer != "4")
            {
                carAmount = 4;
            } else if (answer != "5")
            {
                carAmount = 5;
            }

            //Makes a carlist for our cars.
            List<Car> carList = new List<Car>();
            //Loops as many times as we had cars to enter all our cars into the list.
            for (int i = carAmount; i == 0; i--)
            {
                //Makes a car to put into the list
                Car c = new CleanCar();

                //Randomizes between 1 and 2 to see if the car is clean or contraband.
                int carStatus = Car.generator.Next(1, 3);
                if (carStatus == 1)
                {
                    //Adds a clean car to the list.
                    carList.Add(c = new CleanCar()); 
                }
                else
                {
                    //Adds a contraband car to the list.
                    carList.Add(c = new ContrabandCar());
                }
            }
            //Makes a loop for checking if cars are clean or not.
            bool loop = true;
            while (loop == true)
            {
                //Clears the console and asks the player about what to do.
                Console.Clear();
                Console.WriteLine("To exit: Type exit\nTo check a car: Write the cars corresponding number");
                string answer2 = Console.ReadLine();

                //If the player answered exit then the loop is exited and the program is closed down.
                if (answer2 == "exit" || answer2 == "Exit")
                {
                    loop = false;
                }

                if (answer2 == "1")
                {
                    if (carList[0].alreadyChecked == true)
                    {
                        Console.WriteLine("This car has already been checked.");
                    }
                    else
                    {
                        carList[0].alreadyChecked = true;
                        bool clean = carList[0].Examine();
                        if (clean == true)
                        {
                            Console.WriteLine("The car is clean!");
                        } else
                        {
                            Console.WriteLine("The car has contraband!");
                        }
                    }
                }
                else if (answer2 == "2")
                {
                    if (carList[1].alreadyChecked == true)
                    {
                        Console.WriteLine("This car has already been checked.");
                    }
                    else
                    {
                        carList[1].alreadyChecked = true;
                        bool clean = carList[1].Examine();
                        if (clean == true)
                        {
                            Console.WriteLine("The car is clean!");
                        }
                        else
                        {
                            Console.WriteLine("The car has contraband!");
                        }
                    }
                }
                else if (answer2 == "3")
                {
                    if (carList[2].alreadyChecked == true)
                    {
                        Console.WriteLine("This car has already been checked.");
                    }
                    else
                    {
                        carList[2].alreadyChecked = true;
                        bool clean = carList[2].Examine();
                        if (clean == true)
                        {
                            Console.WriteLine("The car is clean!");
                        }
                        else
                        {
                            Console.WriteLine("The car has contraband!");
                        }
                    }
                }
                else if (answer2 == "4")
                {
                    if (carList[3].alreadyChecked == true)
                    {
                        Console.WriteLine("This car has already been checked.");
                    }
                    else
                    {
                        carList[3].alreadyChecked = true;
                        bool clean = carList[3].Examine();
                        if (clean == true)
                        {
                            Console.WriteLine("The car is clean!");
                        }
                        else
                        {
                            Console.WriteLine("The car has contraband!");
                        }
                    }
                }
                else if (answer2 == "5")
                {
                    if (carList[4].alreadyChecked == true)
                    {
                        Console.WriteLine("This car has already been checked.");
                    }
                    else
                    {
                        carList[4].alreadyChecked = true;
                        bool clean = carList[4].Examine();
                        if (clean == true)
                        {
                            Console.WriteLine("The car is clean!");
                        }
                        else
                        {
                            Console.WriteLine("The car has contraband!");
                        }
                    }

                }

            }
            
        }

    }

}
