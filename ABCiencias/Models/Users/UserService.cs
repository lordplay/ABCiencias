using ABCiencias.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCiencias.Models.Servicos.Users
{
    public class UserService : IUserService
    {
        private IABCienciasContext _context;
        public UserService(IABCienciasContext context)
        {
            _context = context;
        }

        public UserDTO Autentica(UserDTO user)
        {
            return _context.Users.Where(x => x.Email == user.Email && x.Passoword == x.Passoword).Select(c => new UserDTO { IdUser = c.IdUser, Name = c.Nome, Email = c.Email }).FirstOrDefault();
        }
    }
}
