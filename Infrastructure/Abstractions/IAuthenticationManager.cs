using Infrastructure.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDTO userForAuthenticationDTO);

        Task<string> CreateToken();
    }
}
