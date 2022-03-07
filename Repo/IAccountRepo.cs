using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repo
{
    public interface IAccountRepo
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);

        public Task<string> LoginInAsync(SignInModel signUpModel);

    }
}
