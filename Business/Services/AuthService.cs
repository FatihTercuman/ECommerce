using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Responses;

namespace Business.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<Customer> userManager;
        private readonly SignInManager<Customer> signInManager;


        public AuthService(UserManager<Customer> userManager, SignInManager<Customer> signInManager)
        {
            this.userManager = userManager;
            this.signInManager= signInManager;
        }

        public async Task<IResult> LoginAsync(LoginDto model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                return Result.Success();
            }
            else if (result.IsLockedOut)
            {
                return Result.Failure("Hesabınız güvenlik nedeniyle kilitlenmiştir. Lütfen daha sonra tekrar deneyiniz", 403);
            }
            else if (result.IsNotAllowed)
            {
                return Result.Failure("Bu hesapla giriş yapmaya izin verilmemiştir. Hesabınızı doğrulayın.", 403);
            }
            else if (result.RequiresTwoFactor)
            {
                return Result.Failure("İki faktörlü doğrulama gereklidir", 400);
            }
            else
            {
                return Result.Failure("Kullanıcı adı veya şifre yanlış!", 401);
            }
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> RegisterAsync(RegisterDto model)
        {
            throw new NotImplementedException();
        }
    }

}
