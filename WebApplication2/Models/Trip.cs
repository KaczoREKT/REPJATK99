namespace DefaultNamespace;

public class Trip
{
    public int IdTrip { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int MaxPeople { get; set; }

    public ICollection<CountryTrip> TripCountries { get; set; }
    public ICollection<ClientTrip> ClientTrips { get; set; }
}