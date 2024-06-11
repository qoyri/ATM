using ATM.Models;

namespace ATMApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public int UserId { get; set; }
        public int AccountId { get; set; }

        public virtual User User { get; set; }
        public virtual Account Account { get; set; }
    }
}