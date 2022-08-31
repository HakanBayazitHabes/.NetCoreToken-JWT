using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service.Service    
{
    internal static class SignService
    {
        public static SecurityKey GetSymetricSecuritySecurityKey(string securitKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securitKey));
        } 
    }
}
