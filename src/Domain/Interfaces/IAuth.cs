using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces;

public interface IAuth
{
    string GenerateToken();
    string GetClaims(string token);
    //UserDTO GetUserByToken(string token);
    string GenerateSecret();
}
