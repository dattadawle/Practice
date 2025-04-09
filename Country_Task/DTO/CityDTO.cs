
public class CityDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StateId { get; set; }
    public StateDTO State { get; set; }

}