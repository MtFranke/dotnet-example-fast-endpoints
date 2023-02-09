namespace Example.API.DTO;

public class UserRegisterRequest
{
    /// <summary>
    /// Pesel is unique identifier of ppl in Poland
    /// </summary>
    public string Pesel { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}