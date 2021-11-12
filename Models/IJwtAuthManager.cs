using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public interface IJwtAuthManager
    {
        string Authenticate(string username, string password);
    }
}
