namespace SCSIMS.Services;

public class ValidationService : IValidationService, IService
{
    // Fields
    private readonly string emailPattern;
    private readonly string schYrPattern;
    private readonly string pNumPattern;

    public ValidationService()
    {
        emailPattern = @"^[^@\s\d]+[^@\s]*@[^@\s\d]+[^@\s]*\.(com|net|org|gov|ph)$";
        schYrPattern = @"^[\d]{4}-[\d]{4}$";
        pNumPattern = @"^[\d]{10}$";
    }

    // Validation Methods
    public bool ValidateEmail(string txtEmail)
    {
        return System.Text.RegularExpressions.
            Regex.IsMatch(txtEmail, emailPattern);
    }

    public bool ValidatePhoneNum(string num)
    {
        return System.Text.RegularExpressions.
            Regex.IsMatch(num, pNumPattern);
    }

    public bool ValidateSchYr(string txtSchYr)
    {
        return System.Text.RegularExpressions.
            Regex.IsMatch(txtSchYr, schYrPattern);
    }
}