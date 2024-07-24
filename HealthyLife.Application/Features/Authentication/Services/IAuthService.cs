using HealthyLife.Application.Features.Authenticaion.Dtos;

namespace HealthyLife.Application.Features.Authentication.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(LoginRequest loginDto);
        Task<RegistrationResponse> Register(RegisterRequest registerDto);
    }
}
