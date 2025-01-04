namespace SCSIMS.Services;

public class InputDataService : IInputDataService, IService
{
    // Events
    public event EventHandler? ProcessToRun;
    public event EventHandler? InputClear;
    public event EventHandler? InputError;

    // Fields
    private bool _completed;
    private string? _error;

    public InputDataService()
    {
    }

    // Properties
    public Student? StudentData { get; private set; }
    public bool CanUse { get; private set; }

    // Event Handlers
    public void OnProcessToRun()
    {
        _error = null;
        StudentData = null;
        ProcessToRun?.Invoke(this, EventArgs.Empty);
    }

    public void OnInputClear()
    {
        _error = null;
        StudentData = null;
        InputClear?.Invoke(this, EventArgs.Empty);
    }

    public void OnInputError()
    {
        InputError?.Invoke(this, EventArgs.Empty);
    }

    // Set all the data to this method from FormAppForm1 Form.
    public void SetFormAppForm1Data(string fname, string mname, string lname, string ename,
        DateTime? bdate, string pdate, string gender, byte age, string cHouseNo, string cStreet,
        string cCountry, string cProvince, string cCity, string cBrgy, short cZip,
        string pHouseNo, string pStreet, string pCountry, string pProvince, string pCity,
        string pBrgy, short pZip)
    {
        if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(mname) || string.IsNullOrWhiteSpace(lname) ||
            bdate == null || string.IsNullOrWhiteSpace(pdate) || string.IsNullOrWhiteSpace(gender) || age <= 0 || string.IsNullOrWhiteSpace(cHouseNo) ||
            string.IsNullOrWhiteSpace(cStreet) || string.IsNullOrWhiteSpace(cCountry) || string.IsNullOrWhiteSpace(cProvince) || string.IsNullOrWhiteSpace(cCity) ||
            string.IsNullOrWhiteSpace(cBrgy) || cZip <= 0 || string.IsNullOrWhiteSpace(pHouseNo) || string.IsNullOrWhiteSpace(pStreet) ||
            string.IsNullOrWhiteSpace(pCountry) || string.IsNullOrWhiteSpace(pProvince) || string.IsNullOrWhiteSpace(pCity) || string.IsNullOrWhiteSpace(pBrgy) ||
            pZip <= 0)
        {
            _completed = false;
            CanUse = false;
        }
        else
        {
            // Set all data to the model 'student' instance.
            if (StudentData == null)
            {
                StudentData = new Student();
            }

            StudentData.FName = fname;
            StudentData.MName = mname;
            StudentData.LName = lname;
            StudentData.EName = string.IsNullOrWhiteSpace(ename) ? "N/A" : ename;
            StudentData.BDate = bdate.Value;
            StudentData.BPlace = pdate;
            StudentData.Gender = gender;
            StudentData.Age = age;
            StudentData.Current = new Address
            {
                HouseNo = cHouseNo,
                StreetName = cStreet,
                Country = cCountry,
                Prov = cProvince,
                City = cCity,
                Brgy = cBrgy,
                Zip = cZip
            };
            StudentData.Permanent = new Address
            {
                HouseNo = pHouseNo,
                StreetName = pStreet,
                Country = pCountry,
                Prov = pProvince,
                City = pCity,
                Brgy = pBrgy,
                Zip = pZip
            };

            // SetFormAppForm2Data needs to be run first to complete the input
            _completed = false;
            CanUse = false;
        }
    }

    // Set all the data to this method from FormAppForm2 Form.
    public void SetFormAppForm2Data(string ffName, string fmName, string flName, string fNo,
        string mfName, string mmName, string mlName, string mNo, string lfName, string lmName,
        string llName, string lNo, byte lYrLvlC, short lSchYrC1, short lSchYrC2, string lSchAtt,
        string schId, string course, string no, string email, string filePath)
    {
        if (string.IsNullOrWhiteSpace(ffName) || string.IsNullOrWhiteSpace(fmName) || string.IsNullOrWhiteSpace(flName) || string.IsNullOrWhiteSpace(fNo) ||
            string.IsNullOrWhiteSpace(mfName) || string.IsNullOrWhiteSpace(mmName) || string.IsNullOrWhiteSpace(mlName) || string.IsNullOrWhiteSpace(mNo) ||
            string.IsNullOrWhiteSpace(lfName) || string.IsNullOrWhiteSpace(lmName) || string.IsNullOrWhiteSpace(llName) || string.IsNullOrWhiteSpace(lNo) ||
            lYrLvlC < 0 || lSchYrC1 == -2 || lSchYrC2 == -2 || string.IsNullOrWhiteSpace(lSchAtt) || string.IsNullOrWhiteSpace(schId) ||
            string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(no) || string.IsNullOrWhiteSpace(filePath))
        {
            _completed = false;
            CanUse = false;
        }
        else if (email == "Invalid" || fNo == "Invalid" || mNo == "Invalid" || lNo == "Invalid" || no == "Invalid" || lSchYrC1 == -1 || lSchYrC2 == -1)
        {
            _error = mess.InvalidInput;

            _completed = true;
            CanUse = false;
        }
        else
        {
            StudentData!.Guardian = new Guardian
            {
                Father = new BasicInfo { FName = ffName, MName = fmName, LName = flName, CNumber = fNo },
                Mother = new BasicInfo { FName = mfName, MName = mmName, LName = mlName, CNumber = mNo },
                Legal = new BasicInfo { FName = lfName, MName = lmName, LName = llName, CNumber = lNo }
            };
            StudentData!.Transferee = new TransfereeInfo
            {
                LYrLvlC = lYrLvlC,
                LSchYrC1 = lSchYrC1,
                LSchYrC2 = lSchYrC2,
                LSchAtt = lSchAtt,
                SchoolId = schId
            };
            StudentData!.Course = course;
            StudentData!.CNumber = no;
            StudentData!.Email = string.IsNullOrWhiteSpace(email) ? "N/A" : email;
            StudentData!.Filepath = filePath;

            _completed = true;
            CanUse = false;
        }
    }

    // Set all the data to this method from FormAppForm3 Form.
    public void SetFormAppForm3Data(DateTime dateTime)
    {
        if (_completed == false)
        {
            _error = mess.NullInputs;
        }

        if (!string.IsNullOrWhiteSpace(_error))
        {
            throw new Exception(_error);
        }

        StudentData!.EDate = dateTime.Date;
        StudentData!.ETime = dateTime.TimeOfDay;

        CanUse = true;
    }
}
