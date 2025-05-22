using System;
using System.Collections.Generic;
using System.Linq;

public class RentalService
{
    public List<Game> Games { get;  set; } = new List<Game>();
    public List<Customer> Customers { get;  set; } = new List<Customer> ();

    
    public RentalService()
    {
        Games = new List<Game>();
        Customers = new List<Customer>();
    }

    public void AddGame(Game game)
    {
        Games.Add(game);
        Console.WriteLine($"Játék hozzáadva: {game.Title}");
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
        Console.WriteLine($"Ügyfél hozzáadva: {customer.Name}");
    }

    
    public bool RentGame(string customerName, string gameId)
    {
        Customer customer = FindCustomer(customerName);
        Game game = FindGame(gameId);

        if (customer != null && game != null && game.IsAvailable)
        {
            customer.RentGame(game);
            return true;
        }

        Console.WriteLine("Sikertelen kölcsönzés.");
        return false;
    }

    
    public bool ReturnGame(string customerName, string gameId)
    {
        Customer customer = FindCustomer(customerName);
        Game game = FindGame(gameId);

        if (customer != null && game != null)
        {
            customer.ReturnGame(game);
            return true;
        }

        Console.WriteLine("Sikertelen visszaadás.");
        return false;
    }

    
    public void RemoveGame(string gameID)
    {
        Game game = FindGame(gameID);
        if (game != null)
        {
            Games.Remove(game);
            Console.WriteLine($"Játék törölve: {game.Title}");
        }
        else
        {
            Console.WriteLine("Játék nem található.");
