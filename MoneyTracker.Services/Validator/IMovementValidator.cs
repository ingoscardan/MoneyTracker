namespace MoneyTracker.Services.Validator;

public interface IMovementValidator
{
    void Next(IMovementValidator validator);
    void ProcessCharge();
    void ProcessPayment();
    void ValidateCharge();
    void ValidatePayment();
}