using System;
using System.Linq;

namespace Project2
{
    public class Authenticator
    {
        private MyModel _context;
        public Authenticator(MyModel context)
        {
            _context = context;
        }
        public bool Authenticate(string login, string password)
        {
            var existingUser = _context.Users.FirstOrDefault(x => x.userName == login && x.password == password);
            if(existingUser != null)
            {
                AppState.CurrentUser = existingUser;
                return true;
            }

            return false;
        }

    }
}