using ATM.Data;
using System.Linq;

namespace ATM.Services
{
    public class AuthService
    {
        private readonly ATMContext _context;

        public AuthService(ATMContext context)
        {
            _context = context;
        }

        public bool Authenticate(string cardNumber, string pinCode)
        {
            try
            {
                var card = _context.Cards.SingleOrDefault(c => c.CardNumber == cardNumber && c.PinCode == pinCode);
                return card != null;
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }
    }
}