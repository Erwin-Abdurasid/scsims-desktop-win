namespace SCSIMS.Models;

public class Guardian
{
    public int? Id { get; set; }
    public int? StudentId { get; set; }

    // Foreign Tables
    public BasicInfo? Father { get; set; }
    public BasicInfo? Mother { get; set; }
    public BasicInfo? Legal { get; set; }
}
