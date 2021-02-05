using System;
using System.Collections.Generic;

namespace CS133MIDTERMPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();


            myRestaurant.ClientsToArrive("First Client ");
            myRestaurant.ClientsToArrive("Second Client ");
            myRestaurant.ClientsToArrive("Third Client ");
            myRestaurant.ClientsToArrive("Fourth Client ");
            myRestaurant.ClientsToArrive("Fifth Client ");

            myRestaurant.ShowMeHowManyClientsAreWaiting();
            myRestaurant.ClientsCanBeSitted();
            myRestaurant.ShowMeHowManyClientsAreWaiting();

            myRestaurant.ClientsLeave();

            myRestaurant.PorterCleansDishes();

            myRestaurant.HowManyDirtyDishesDoIHave();

            
        }
    }
}
public class Restaurant
{
    Queue<string> myQueue = new Queue<string>();
    Stack<string> dirtyDishesStack = new Stack<string>();
    Stack<string> cleanDishesStack = new Stack<string>();

    public void ClientsToArrive(string theClient)
    {
        myQueue.Enqueue(theClient);
    }

    public void ShowMeHowManyClientsAreWaiting()
    {
        Console.WriteLine(" We have " +
                          myQueue.Count +
                          " Clients Waiting ");
    }

    public void ClientsCanBeSitted()
    {

        {
            string theClien = myQueue.Dequeue();
            Console.WriteLine("Clients:" + theClien + "has been sitted");
        }
    }

    public void ClientsLeave()
    {
        dirtyDishesStack.Push("Dish 1");

        Console.WriteLine("Client paid and Leave");
    }

    public void PorterCleansDishes()
    {
       
        {
            string theDish = dirtyDishesStack.Pop();
            cleanDishesStack.Push(theDish);

            Console.WriteLine("POrter has cleaned a dish");
        }
    }
    public void HowManyDirtyDishesDoIHave()
    {
        Console.WriteLine("The restaurant has these many dirty dishes left:  " + dirtyDishesStack.Count);
    }

   
}