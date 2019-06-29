using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinAssemble2019.Core.Features.LogOn
{
    public interface IAuthenticationService
    {
        void SetParent(object parent);
        Task<UserContext> SignInAsync();
        Task<UserContext> SignOutAsync();
        Task<UserContext> EditProfileAsync();
        Task<UserContext> ResetPasswordAsync();
    }
}