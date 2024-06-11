using ATMApp.Models;

namespace ATM.Models;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Type { get; set; } // Par exemple, "Withdrawal", "Deposit"
    public int CardId { get; set; }
    public virtual Card Card { get; set; }
}
