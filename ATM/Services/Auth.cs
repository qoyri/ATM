using ATM.Data;

namespace ATM.Services;
using System.Linq;

public class AuthService
{
    private readonly ATMContext _context;

    public AuthService(ATMContext context)
    {
        _context = context;
    }

    public bool Authenticate(string cardNumber, string pinCode)
    {
        var card = _context.Cards.SingleOrDefault(c => c.CardNumber == cardNumber && c.PinCode == pinCode);
        return card != null;
    }
}

