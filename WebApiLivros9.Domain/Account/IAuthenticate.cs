using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLivros9.Domain.Entities;

namespace WebApiLivros9.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string email, string senha);
        Task<bool> UserExists(string email);
        public string GenerateToken(int id, string email);
        public Task<Usuario> GetUserbyEmail(string email);

    }
}
