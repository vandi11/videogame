using System;

public class Game
{
    public string GameID { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public bool IsAvailable { get; set; }
    public decimal PricePerDay { get; set; }

    
    public Game(string gameID, string title, string genre, int releaseYear, decimal pricePerDay)
    {
        GameID = gameID;
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        PricePerDay = pricePerDay;
        IsAvailable = true;
    }

    
    public override string ToString()
    {
        return $"{Title} ({Genre}, {ReleaseYear}) - ID: {GameID}, Ár/Nap: {PricePerDay}, Elérhető: {IsAvailable}";
    }
}

