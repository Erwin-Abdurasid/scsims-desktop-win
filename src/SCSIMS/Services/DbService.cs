namespace SCSIMS.Services;

// Database Service class
public class DbService : IDbService, IService
{
    enum SpecifiedNumberOfData : byte
    {
        Course = 4,
        Province = 88
    }

    // Fields
    private readonly string _connStr;
    private int _currentDataCount = 0;

    public DbService()
    {
        // Adding DB connection string to the connection
        _connStr = System.Configuration.
            ConfigurationManager.ConnectionStrings["SCSIMS_DB"].ConnectionString;
    }

    // Student's Data
    public async Task<bool> AddNewAsync(Student student)
    {
        if (student.Current != null && student.Permanent != null && student.Guardian != null &&
        student.Transferee != null && student.Guardian.Father != null &&
        student.Guardian.Mother != null && student.Guardian.Legal != null)
        {
            int studentId = await ProcessStudentInsertionAsync(student);

            await ProcessAddressInsertionAsync(student.Current, studentId);
            await ProcessAddressInsertionAsync(student.Permanent, studentId);

            int guardianId = await ProcessGuardianInsertionAsync(studentId);

            await ProcessBasicInfoInsertionAsync(student.Guardian.Father, guardianId);
            await ProcessBasicInfoInsertionAsync(student.Guardian.Mother, guardianId);
            await ProcessBasicInfoInsertionAsync(student.Guardian.Legal, guardianId);
            await ProcessTransfereeInfoInsertionAsync(student.Transferee, studentId);

            return true;
        }

        return false;
    }

    public async ValueTask<bool> AddYrLvlAsync(int id, byte yrLvl)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand command = new SqlCommand(comm.INSERT_STUDENT_YRLVL);

        command.Parameters.Add(new SqlParameter("@YrLvl", yrLvl));
        command.Parameters.Add(new SqlParameter("@Id", id));

        conn.Open();
        command.Connection = conn;
        await command.ExecuteNonQueryAsync();

        conn.Close();
        return true;
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Student>?> ReadAsync()
    {
        throw new NotImplementedException();
    }

    // Checking if the data is refreshable under ReadToDisplayAsync().
    public async ValueTask<bool> RefreshableAsync()
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand command = new SqlCommand(comm.SELECT_STUDENTS_TO_REFRESH);

        conn.Open();
        command.Connection = conn;
        using SqlDataReader sdr = await command.ExecuteReaderAsync();

        int dataCount = 0;
        while (sdr.Read())
        {
            dataCount = sdr.GetInt32(0);
        }

        conn.Close();
        // Check if the number of data isn't changed
        if (dataCount == _currentDataCount)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public async Task<IEnumerable<StudentsDataViewModel>?> ReadToDisplayAsync()
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand comCount = new SqlCommand(comm.SELECT_STUDENTS_TO_REFRESH);
        using SqlCommand command = new SqlCommand(comm.SELECT_STUDENTS_TO_DISPLAY);

        conn.Open();
        comCount.Connection = conn;
        command.Connection = conn;
        // Get the count of the data so we can explicitly
        // placed number of memories for its list container.
        SqlDataReader sdr = await comCount.ExecuteReaderAsync();

        while (sdr.Read())
        {
            _currentDataCount = sdr.GetInt32(0);
        }

        // List container
        List<StudentsDataViewModel> list =
            new List<StudentsDataViewModel>(_currentDataCount);
        sdr = await command.ExecuteReaderAsync();

        while (sdr.Read())
        {
            list.Add(new StudentsDataViewModel
            {
                Id = sdr.GetInt32(0),
                FName = sdr.GetString(1),
                MName = sdr.GetString(2),
                LName = sdr.GetString(3),
                EName = sdr.GetString(4),
                Course = sdr.GetString(6),
                Gender = sdr.GetString(5),
                Filename = sdr.GetString(7),
                Date = sdr.GetDateTime(8),
                YrLvl = sdr.GetValue(9) == DBNull.Value? null : sdr.GetByte(9)
            });
        }

        conn.Close();
        await sdr.DisposeAsync();
        return list;
    }

    public Task<Student?> ReadByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    // Address' Data
    public async Task<IEnumerable<Brgy>?> GetBrgiesAsync(int cityCode)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand comCount = new SqlCommand(comm.SELECT_BRGIES_COUNT);
        using SqlCommand command = new SqlCommand(comm.SELECT_BRGIES_BY_CITY_ID);

        comCount.Parameters.Add(new SqlParameter("@CityCode", cityCode));
        command.Parameters.Add(new SqlParameter("@CityCode", cityCode));

        conn.Open();
        comCount.Connection = conn;
        command.Connection = conn;

        SqlDataReader sdr = await comCount.ExecuteReaderAsync();

        int dataCount = 0;
        while (sdr.Read())
        {
            dataCount = sdr.GetInt32(0);
        }

        List<Brgy> brgies = new List<Brgy>(dataCount);
        sdr = await command.ExecuteReaderAsync();

        while (sdr.Read())
        {
            brgies.Add(new Brgy
            {
                Id = sdr.GetInt32(0),
                Name = sdr.GetString(1)
            });
        }

        conn.Close();
        await sdr.DisposeAsync();
        return brgies;
    }

    public async Task<Dictionary<string, City>?> GetCitiesAsync(int provCode)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand comCount = new SqlCommand(comm.SELECT_CITIES_COUNT);
        using SqlCommand command = new SqlCommand(comm.SELECT_CITIES_BY_PROVINCE_ID);

        comCount.Parameters.Add(new SqlParameter("@ProvCode", provCode));
        command.Parameters.Add(new SqlParameter("@ProvCode", provCode));

        conn.Open();
        comCount.Connection = conn;
        command.Connection = conn;

        int dataCount = 0;
        SqlDataReader sdr = await comCount.ExecuteReaderAsync();
        while (sdr.Read())
        {
            dataCount = sdr.GetInt32(0);
        }

        Dictionary<string, City> cities = new Dictionary<string, City>(dataCount);
        sdr = await command.ExecuteReaderAsync();

        while (sdr.Read())
        {
            cities.Add(sdr.GetString(1), new City
            {
                Id = sdr.GetInt32(0),
                Name = sdr.GetString(1),
                Code = Convert.ToInt32(sdr.GetString(2))
            });
        }

        conn.Close();
        await sdr.DisposeAsync();
        return cities;
    }

    public async Task<Dictionary<string, Province>?> GetProvincesAsync()
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand command = new SqlCommand(comm.SELECT_PROVINCES);

        conn.Open();
        command.Connection = conn;

        Dictionary<string, Province> provinces =
            new Dictionary<string, Province>((byte)SpecifiedNumberOfData.Province);
        using SqlDataReader sdr = await command.ExecuteReaderAsync();

        while (sdr.Read())
        {
            provinces.Add(sdr.GetString(1), new Province
            {
                Id = sdr.GetInt32(0),
                Name = sdr.GetString(1),
                Code = Convert.ToInt32(sdr.GetString(2))
            });
        }

        conn.Close();
        return provinces;
    }

    // Course' Data
    public async Task<IEnumerable<Course>?> GetCoursesAsync()
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand command = new SqlCommand(comm.SELECT_COURSES);

        conn.Open();
        command.Connection = conn;

        List<Course> courses = new List<Course>((byte)SpecifiedNumberOfData.Course);
        using SqlDataReader sdr = await command.ExecuteReaderAsync();

        while (sdr.Read())
        {
            courses.Add(new Course
            {
                Id = sdr.GetInt32(0),
                Name = sdr.GetString(1),
                Abbr = sdr.GetString(2)
            });
        }

        conn.Close();
        return courses;
    }

    // Support methods
    private async Task<int> ProcessStudentInsertionAsync(Student student)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand commStudent = new SqlCommand(comm.INSERT_STUDENT);
        using SqlCommand commStudentId = new SqlCommand(comm.SELECT_STUDENT_ID);

        commStudent.Parameters.AddRange(
            new SqlParameter[]
            {
                new SqlParameter("@FName", student.FName),
                new SqlParameter("@MName", student.MName),
                new SqlParameter("@LName", student.LName),
                new SqlParameter("@EName", student.EName),
                new SqlParameter("@BDate", student.BDate?.Date),
                new SqlParameter("@BPlace", student.BPlace),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@Age", student.Age),
                new SqlParameter("@Course", student.Course),
                new SqlParameter("@Number", student.CNumber),
                new SqlParameter("@Email", student.Email),
                new SqlParameter("@FilePath", student.Filepath),
                new SqlParameter("@DateEnrolled", student.EDate?.Date),
                new SqlParameter("@TimeEnrolled", student.ETime),
                new SqlParameter("@AssignedYrLvl", DBNull.Value)
            }
        );

        conn.Open();
        commStudent.Connection = conn;
        commStudentId.Connection = conn;

        await commStudent.ExecuteNonQueryAsync();

        int studentId = 0;
        using SqlDataReader sdr = await commStudentId.ExecuteReaderAsync();

        while (sdr.Read())
        {
            studentId = sdr.GetInt32(0);
        }

        conn.Close();
        return studentId;
    }

    private async ValueTask ProcessAddressInsertionAsync(Address address, int studentId)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand commAddress = new SqlCommand(comm.INSERT_ADDRESS);
        
        commAddress.Parameters.AddRange(
            new SqlParameter[]
            {
                new SqlParameter("@StudentId", studentId),
                new SqlParameter("@HouseNo", address.HouseNo),
                new SqlParameter("@StreetName", address.StreetName),
                new SqlParameter("@Country", address.Country),
                new SqlParameter("@Province", address.Prov),
                new SqlParameter("@City", address.City),
                new SqlParameter("@Brgy", address.Brgy),
                new SqlParameter("@Zip", address.Zip)
            }
        );

        conn.Open();
        commAddress.Connection = conn;

        await commAddress.ExecuteNonQueryAsync();
        conn.Close();
    }

    private async Task<int> ProcessGuardianInsertionAsync(int studentId)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand commGuard = new SqlCommand(comm.INSERT_GUARDIAN);
        using SqlCommand commGuardId = new SqlCommand(comm.SELECT_GUARDIAN_ID);

        commGuard.Parameters.Add(new SqlParameter("@StudentId", studentId));

        conn.Open();
        commGuard.Connection = conn;
        commGuardId.Connection = conn;

        await commGuard.ExecuteNonQueryAsync();

        int guardId = 0;
        using SqlDataReader sdr = await commGuardId.ExecuteReaderAsync();

        while (sdr.Read())
        {
            guardId = sdr.GetInt32(0);
        }

        conn.Close();
        return guardId;
    }

    private async ValueTask ProcessBasicInfoInsertionAsync(BasicInfo basic, int guardianId)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand commBI = new SqlCommand(comm.INSERT_BASIC_INFO);

        commBI.Parameters.AddRange(new SqlParameter[]
        {
            new SqlParameter("@GuardianId", guardianId),
            new SqlParameter("@FName", basic.FName),
            new SqlParameter("@MName", basic.MName),
            new SqlParameter("@LName", basic.LName),
            new SqlParameter("@Number", basic.CNumber)
        });

        conn.Open();
        commBI.Connection = conn;

        await commBI.ExecuteNonQueryAsync();
        conn.Close();
    }

    private async ValueTask ProcessTransfereeInfoInsertionAsync(TransfereeInfo info, int studentId)
    {
        using SqlConnection conn = new SqlConnection(_connStr);
        using SqlCommand commTransI = new SqlCommand(comm.INSERT_TRANSFEREE_INFO);
        
        commTransI.Parameters.AddRange(new SqlParameter[]
        {
            new SqlParameter("@StudentId", studentId),
            new SqlParameter("@LastYrLvl", info.LYrLvlC),
            new SqlParameter("@LastSchYr1", info.LSchYrC1),
            new SqlParameter("@LastSchYr2", info.LSchYrC2),
            new SqlParameter("@LastSchAtt", info.LSchAtt),
            new SqlParameter("@SchId", info.SchoolId)
        });

        conn.Open();
        commTransI.Connection = conn;

        await commTransI.ExecuteNonQueryAsync();
        conn.Close();
    }
}