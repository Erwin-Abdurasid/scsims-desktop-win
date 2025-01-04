namespace SCSIMS.Services.Contracts;

public interface IInputDataService
{
    // Events
    event EventHandler? ProcessToRun;
    event EventHandler? InputClear;
    event EventHandler? InputError;

    // Properties
    Student? StudentData { get; }
    bool CanUse { get; }

    // Event Handlers
    void OnProcessToRun();
    void OnInputClear();
    void OnInputError();

    // Methods
    void SetFormAppForm1Data(string fname, string mname, string lname, string ename,
        DateTime? bdate, string pdate, string gender, byte age, string cHouseNo, string cStreet,
        string cCountry, string cProvince, string cCity, string cBrgy, short cZip,
        string pHouseNo, string pStreet, string pCountry, string pProvince, string pCity,
        string pBrgy, short pZip);
    void SetFormAppForm2Data(string ffName, string fmName, string flName, string fNo,
        string mfName, string mmName, string mlName, string mNo, string lfName, string lmName,
        string llName, string lNo, byte lYrLvlC, short lSchYrC1, short lSchYrC2, string lSchAtt,
        string schId, string course, string no, string email, string filePath);
    void SetFormAppForm3Data(DateTime dateTime);
}
