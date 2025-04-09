public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public string Address { get; set; }

    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }

    public Country? Country { get; set; }
    public State? State { get; set; }
    public City? City { get; set; }
}