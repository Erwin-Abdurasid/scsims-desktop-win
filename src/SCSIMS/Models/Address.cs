namespace SCSIMS.Models;

public class Address
{
    public int? Id { get; set; }
    public int? StudentId { get; set; }
    public string? HouseNo { get; set; }
    public string? StreetName { get; set; }
    public string? Brgy { get; set; }
    public string? City { get; set; }
    public string? Prov { get; set; }
    public string? Country { get; set; }
    public short? Zip { get; set; }
}
