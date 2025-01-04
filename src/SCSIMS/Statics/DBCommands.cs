namespace SCSIMS.Statics;

// ALl commands for DB are organized in this struct.
public static class DBCommands
{
    // Student's Commands
    public const string INSERT_STUDENT = @"
                                INSERT INTO [dbo].[Student]
                                VALUES (
	                                @FName,
                                    @MName,
                                    @LName,
                                    @EName,
                                    @BDate,
                                    @BPlace,
                                    @Gender,
                                    @Age,
                                    @Course,
                                    @Number,
                                    @Email,
                                    @FilePath,
                                    @DateEnrolled,
                                    @TimeEnrolled,
                                    @AssignedYrLvl
                                );
                            ";

    public const string INSERT_STUDENT_YRLVL = @"
                                UPDATE [dbo].[Student]
                                SET [AssignedYrLvl] = @YrLvl
                                WHERE Id = @Id
                            ";

    public const string SELECT_STUDENT_ID = @"
                                SELECT Id FROM [dbo].[Student]
                                WHERE Id = (SELECT MAX(Id) FROM [dbo].[Student]);
                            ";

    public const string INSERT_ADDRESS = @"
                                INSERT INTO [dbo].[Address]
                                VALUES (
	                                @StudentId,
                                    @HouseNo,
                                    @StreetName,
                                    @Country,
	                                @Province,
                                    @City,
                                    @Brgy,
                                    @Zip
                                );
                            ";

    public const string INSERT_GUARDIAN = @"
                                INSERT INTO [dbo].[Guardian]
                                VALUES (@StudentId);
                            ";

    public const string SELECT_GUARDIAN_ID = @"
                                SELECT Id FROM [dbo].[Guardian]
                                WHERE Id = (SELECT MAX(Id) FROM [dbo].[Guardian]);
                            ";

    public const string INSERT_BASIC_INFO = @"
                                INSERT INTO [dbo].[BasicInfo]
                                VALUES (
                                    @GuardianId,
                                    @FName,
                                    @MName,
                                    @LName,
                                    @Number
                                );
                            ";

    public const string INSERT_TRANSFEREE_INFO = @"
                                INSERT INTO [dbo].[TransfereeInfo]
                                VALUES (
                                    @StudentId,
                                    @LastYrLvl,
                                    @LastSchYr1,
                                    @LastSchYr2,
                                    @LastSchAtt,
                                    @SchId
                                );
                            ";

    public const string SELECT_STUDENTS_TO_DISPLAY = @"
                                SELECT [Id], [FName], [MName], [LName], [EName], [Gender], [Course], [FilePath], [DateEnrolled], [AssignedYrLvl]
                                FROM [dbo].[Student]
                                ORDER BY Id DESC;
                            ";

    public const string SELECT_STUDENTS_TO_REFRESH = @"
                                SELECT COUNT(Id) FROM [dbo].[Student];
                            ";

    // Address's Commands
    public const string SELECT_PROVINCES = @"
                                SELECT Id, ProvDesc, ProvCode FROM [dbo].[Province];
                            ";

    public const string SELECT_CITIES_COUNT = @"
                                SELECT COUNT(Id) FROM [dbo].[City]
                                WHERE ProvCode = @ProvCode;
                            ";

    public const string SELECT_CITIES_BY_PROVINCE_ID = @"
                                SELECT Id, CityDesc, CityCode FROM [dbo].[City]
                                WHERE ProvCode = @ProvCode;
                            ";

    public const string SELECT_BRGIES_COUNT = @"
                                SELECT COUNT(Id) FROM [dbo].[Brgy]
                                WHERE CityCode = @CityCode;
                            ";

    public const string SELECT_BRGIES_BY_CITY_ID = @"
                                SELECT Id, BrgyDesc FROM [dbo].[Brgy]
                                WHERE CityCode = @CityCode;
                            ";

    // Course' Commands
    public const string SELECT_COURSES = @"
                                SELECT Id, [Name], Abbr FROM [dbo].[Course];
                            ";
}
