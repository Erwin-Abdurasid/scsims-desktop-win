namespace SCSIMS.Services.Contracts;

public interface IFilterService
{
    // Fields
    string? FirstName { set; }
    string? Midname { set; }
    string? LastName { set; }
    string? ExtName { set; }
    string? Course { set; }
    string? Gender { set; }
    byte? YearLevel { set; }
    string? Date { set; }

    // Methods
    IEnumerable<StudentsDataViewModel>? FilterNow(IEnumerable<StudentsDataViewModel>? toFilter);
}
