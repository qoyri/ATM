using ATMApp.Models;

namespace ATM.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Card> Cards { get; set; }
}