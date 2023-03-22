namespace MoneyTracker.Services.Models;

public class PaymentMovement: Movement
{
    public PaymentMovement()
    {
        Type = MovementType.Payment;
    }
}