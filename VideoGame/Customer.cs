using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Customer
    {
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public List<Game> RentedGames { get; set; }

    public Customer(int customerId, string name, List<Game> rentedGames)
        {
            CustomerId = customerId;
            Name = name;
            RentedGames = rentedGames;
        }
    }

}
