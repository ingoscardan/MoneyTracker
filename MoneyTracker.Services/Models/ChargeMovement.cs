namespace MoneyTracker.Services.Models;

public class ChargeMovement: Movement
{
    public ChargeMovement()
    {
        Type = MovementType.Charge;
    }
}