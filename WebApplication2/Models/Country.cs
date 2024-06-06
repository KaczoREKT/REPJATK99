namespace DefaultNamespace;

public class Country
{
    public int IdCountry { get; set; }
    public string Name { get; set; }

    public ICollection<CountryTrip> TripCountries { get; set; }
}