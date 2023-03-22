namespace MoneyTracker.Services.Validator.MovementValidator;

public abstract class MovementValidator: IMovementValidator
{
    private IMovementValidator? _nextValidator;
    public void Next(IMovementValidator? validator)
    {
        _nextValidator = validator;
    }

    public void ProcessCharge()
    {
        try
        {
            ValidateCharge();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        if (_nextValidator != null)
        {
            _nextValidator.ProcessCharge();
        }

        return;
    }

    public void ProcessPayment()
    {
        try
        {
            ValidatePayment();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        if (_nextValidator != null)
        {
            _nextValidator.ProcessPayment();
        }

        return;
    }

    public virtual void ValidateCharge()
    {
        throw new NotImplementedException();
    }

    public virtual void ValidatePayment()
    {
        throw new NotImplementedException();
    }
}