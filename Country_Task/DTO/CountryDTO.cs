

public class CountryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<StateDTO> States { get; set; }
}