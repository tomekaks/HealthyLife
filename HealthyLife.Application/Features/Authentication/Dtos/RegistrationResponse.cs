namespace HealthyLife.Application.Features.Authenticaion.Dtos
{
    public class RegistrationResponse
    {
        public string UserId { get; set; }
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }
    }
}
