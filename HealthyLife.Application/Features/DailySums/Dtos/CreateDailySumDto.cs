namespace HealthyLife.Application.Features.DailySums.Dtos
{
    public class CreateDailySumDto
    {
        public DateOnly Date { get; set; }
        public string UserId { get; set; }
    }
}
