namespace HealthyLife.Application.Features.Authenticaion.Dtos
{
    public class AuthResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
        public bool Succeeded { get; set; }
        public  List<string> Errors { get; set; }
    }
}
