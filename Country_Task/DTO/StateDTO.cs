public class StateDTO
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CountryId { get; set; }

    public CountryDTO Country { get; set; }
    public ICollection<CityDTO> Citys { get; set; }

}