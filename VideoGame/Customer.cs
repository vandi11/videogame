using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public List<Game> RentedGames { get; set; } = new List<Game>();



    public Customer(int customerID, string name)
    {
        CustomerID = customerID;
        Name = name;
        RentedGames = new List<Game>();
    }

    public void RentGame(Game game)
    {
        if (game.IsAvailable)
        {
            game.IsAvailable = false;
            RentedGames.Add(game);
            Console.WriteLine($"{Name} kikölcsönözte: {game.Title}");
        }
        else
        {
            Console.WriteLine($"Sajnálom, {game.Title} jelenleg nem elérhető.");
        }
    }

    public void ReturnGame(Game game)
    {
        if (RentedGames.Contains(game))
        {
            game.IsAvailable = true;
            RentedGames.Remove(game);
            Console.WriteLine($"{Name} visszaadta: {game.Title}");
        }
        else
        {
            Console.WriteLine($"{Name} nem kölcsönözte ezt a játékot.");
        }
    }

    public List<Customer> ListCostumer()
    {

    }
    
    public override string ToString()
    {
        return $"ID: {CustomerID}, Név: {Name}, Kikölcsönzött játékok: {RentedGames.Count}";
    }
}
