namespace SCSIMS.Services.Contracts;

public interface IDbService
{
    // Student's Methods
    Task<bool> AddNewAsync(Student student);
    ValueTask<bool> AddYrLvlAsync(int id, byte yrLvl);
    Task<Student?> ReadByIdAsync(int id);
    Task<IEnumerable<Student>?> ReadAsync();
    ValueTask<bool> RefreshableAsync();
    Task<IEnumerable<StudentsDataViewModel>?> ReadToDisplayAsync();
    Task<bool> EditAsync(Student student);
    Task<bool> DeleteAsync(int id);

    // Address' Methods
    Task<Dictionary<string, Province>?> GetProvincesAsync();
    Task<Dictionary<string, City>?> GetCitiesAsync(int provCode);
    Task<IEnumerable<Brgy>?> GetBrgiesAsync(int cityCode);

    // Courses Methods
    Task<IEnumerable<Course>?> GetCoursesAsync();
}
