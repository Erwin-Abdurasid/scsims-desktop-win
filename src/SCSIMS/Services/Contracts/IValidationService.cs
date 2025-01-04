namespace SCSIMS.Services.Contracts;

public interface IValidationService
{
    // Methods
    bool ValidateEmail(string email);
    bool ValidateSchYr(string txtSchYr);
    bool ValidatePhoneNum(string num);
}
