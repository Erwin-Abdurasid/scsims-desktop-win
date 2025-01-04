namespace SCSIMS.Models;

public class Student
{
    public int? Id { get; set; }
    public string? FName { get; set; }
    public string? MName { get; set; }
    public string? LName { get; set; }
    public string? EName { get; set; }
    public DateTime? BDate { get; set; }
    public string? BPlace { get; set; }
    public string? Gender { get; set; }
    public byte? Age { get; set; }
    public string? Course { get; set; }
    public string? CNumber { get; set; }
    public string? Email { get; set; }
    public string? Filepath { get; set; }
    public byte? AssignedYrLvl { get; set; }
    public DateTime? EDate { get; set; }
    public TimeSpan? ETime { get; set; }

    // Foreign Tables
    public Address? Current { get; set; }
    public Address? Permanent { get; set; }
    public Guardian? Guardian { get; set; }
    public TransfereeInfo? Transferee { get; set; }
}