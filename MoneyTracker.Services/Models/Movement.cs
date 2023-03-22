namespace MoneyTracker.Services.Models;

public enum MovementStatus
{
    Close = 0,
    Open
}

public enum MovementType
{
    Payment = 1,
    Charge = 2
}


public class Movement
{
    public int MovementId { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ApplicationDate { get; set; }
    public int Account { get; set; }
    public MovementStatus Status { get; set; }
    public MovementType Type { get; set; }
}